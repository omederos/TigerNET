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
            CheckIfTypeAlreadyExists(scope, errors);

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

            //Si no ocurrio ningun error, definimos este tipo nuevo
            scope.Add(new RecordType(Name, new Fields(fields)));
        }
    }
}
