using System;
using System.Collections.Generic;
using System.Linq;
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

        public RecordDeclarationNode(string name, IList<TypeField> fields) : base(name) {
            Fields = fields;
        }
        public RecordDeclarationNode(string name) : this(name, new List<TypeField>()) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
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
                    fields.Add(field.Id, scope.DefinedTypes[field.TypeId]);
                }
            }

            //Si ocurrio un error
            if (errorsCount != errors.Count) {
                return;
            }

            //Si no ocurrio ningun error, actualizamos la definicion de este tipo
            scope.Add(new RecordType(Name, new Fields(fields)), updateIfExists: true);
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
