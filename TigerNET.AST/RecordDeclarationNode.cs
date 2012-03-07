using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class RecordDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Indica los campos del record declarado. Ver clase TypeField
        /// </summary>
        public IList<TypeField> Fields { get; set; }

        public RecordType RecordType { get; set; }

        public RecordDeclarationNode(string name, IList<TypeField> fields) : base(name) {
            Fields = fields;
        }
        public RecordDeclarationNode(string name) : this(name, new List<TypeField>()) {}

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //La declaracion de un record no es mas que declarar una clase, y los parametros/argumentos del record son campos de la clase
            //El problema que puede ocurrir aqui es que el record tenga un parametro de tipo otro record, y que ese otro record no este definido (porque en la secuencia de declaraciones aparece debajo)
            //Pero ya garantizamos que estara creado porque antes de llamarse este metodo, se hace un llamado para crearlos

            Dictionary<string, FieldBuilder> fieldsOfClass = new Dictionary<string, FieldBuilder>();

            //Crear los campos de la clase dentro de este record (parametros/argumentos del record)
            foreach (var field in RecordType.Fields) {
                var name = NamesGenerator.GenerateNewName();
                var fieldOfClass = RecordType.ILRecord.DefineField(name, field.Value.GetILType(),
                                                FieldAttributes.Public);
                fieldsOfClass.Add(name, fieldOfClass);
            }

            //Guardamos los campos asignados en la informacion del record
            RecordType.FieldsInClass = fieldsOfClass;

            //Creamos el constructor de la clase
            var constructor = RecordType.ILRecord.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard,
                                                                    RecordType.Fields.Select(x => x.Value.GetILType()).ToArray());
            RecordType.Constructor = constructor;

            //Cogemos el generador de codigo del constructor 
            var genConstructor = constructor.GetILGenerator();

            int index = 1;
            //Le damos valor a todos los campos en el constructor de la clase
            foreach (var keyPair in RecordType.FieldsInClass) {
                //Cargamos la referencia a 'this'
                genConstructor.Emit(OpCodes.Ldarg_0);
                //Cargamos el campo i-esimo (es a partir de 1 porque el 0 es la referencia a 'this' por no estar en un metodo estatico) y lo ponemos en la pila
                genConstructor.Emit(OpCodes.Ldarg, index);
                //Metemos en la pila el valor que le asignaremos y se lo asignamos al campo que habiamos metido en la pila
                genConstructor.Emit(OpCodes.Stfld, keyPair.Value);
                //Aumentamos el indice
                index += 1;
            }

            //Retornamos en el constructor
            genConstructor.Emit(OpCodes.Ret);

            //Finalmente 'cerramos' el tipo para que pueda ser usado
            RecordType.ILRecord.CreateType();
        }

        /// <summary>
        /// Crea una clase (sin campos) que representara a este record
        /// Este metodo debe ser llamado antes de llamar al GenerateCode
        /// </summary>
        /// <param name="typeBuilder"></param>
        public void CreateRecordClass(TypeBuilder typeBuilder)
        {
            //Guardamos el TypeBuilder de este record en su informacion, para poder usarlo en RecordLiteralNode
            RecordType.ILRecord = Builders.Module.DefineType(RecordType.GetName(), TypeAttributes.Public | TypeAttributes.Class);
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobar que no haya sido definido este tipo (o variable?) anteriormente
            //Comprobar que no haya dos campos con un mismo nombre
            //Comprobar que todos los tipos de los campos esten definidos

            int errorsCount = errors.Count;


            //Chequeamos que un tipo con ese nombre no haya sido definido anteriormente
//            CheckIfTypeAlreadyExists(scope, errors);

            IDictionary<string, TigerType> fields = new Dictionary<string, TigerType>();
            
            foreach (var field in Fields) {
                bool errorInField = false;
                //Comprobando que el tipo de este campo este definido
                if (!scope.ExistsType(field.TypeId)) {
                    errors.Add(new UndefinedTypeError(Line, Column, field.TypeId));
                    errorInField = true;
                }
                //Comprobando que no exista ya un campo con este nombre
                if (fields.ContainsKey(field.Id))
                {
                    errors.Add(new DuplicateFieldError(Line, Column, field.Id));
                    errorInField = true;
                }
                if (!errorInField) {
                    fields.Add(field.Id, scope.GetType(field.TypeId));
                }
            }

            //Si ocurrio un error
            if (errorsCount != errors.Count) {
                return;
            }

            //Si no ocurrio ningun error, actualizamos la definicion de este tipo
            //Guardamos el record en este nodo para usarlo en la generacion de codigo
            RecordType = new RecordType(Name, new Fields(fields));
            scope.Add(RecordType, updateIfExists: true);
        }

        /// <summary>
        /// Actualiza la definicion del record actual
        /// Util en los casos que contenga campos que apunten a el mismo, u a otros records que aun no habian sido
        /// 100% definidos cuando se llamo al CheckSemantic
        /// </summary>
        /// <param name="scope"></param>
        public override void UpdateDefinition(Scope scope) {
            //Esta linea no debe dar ningun error, pues este metodo debe ser llamado antes de llamar al CheckSemantic
            var record = (RecordType)scope.GetType(Name, false);
            //Por cada campo del record...
            for (int i = 0; i < record.Fields.Count; i++) {
                string fieldName = Fields[i].Id;
                //Tipo (en el programa) del campo
                string typeId = Fields[i].TypeId;
                //Hacemos que el tipo real del campo apunte al tipo definido en el Scope
                record.Fields[fieldName] = scope.GetType(typeId);
            }
        }
    }
}
