using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class RecordLiteralNode : NonAtomicLiteralNode
    {
        /// <summary>
        /// Valores de los campos del record que se asignaran
        /// </summary>
        public IList<FieldAssignmentNode> Fields { get; set; }

        public RecordLiteralNode(string name, IList<FieldAssignmentNode> fields) : base(name) {
            Fields = fields;
            foreach (var f in Fields) {
                f.Parent = this;
            }
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobando que exista el record
            if (!scope.ExistsType(Name)) {
                errors.Add(new UndefinedTypeError(Line, Column, Name));
                return;
            }

            var type = scope.GetType(Name);
            var record = type as RecordType;

            //Si el tipo que obtuvimos no es un record...
            if (record == null) {
                errors.Add(new UnexpectedTypeError(Line, Column, type, new RecordType(Name, new Fields())));
                return;
            }

            //Si el record existe..
            
            //Si no coinciden la cantidad de campos
            if (Fields.Count != record.Fields.Count) {
                errors.Add(new MessageError(Line, Column, string.Format("The fields of the declaration do not match fields of the record '{0}'", record.Name)));
                //Para poder seguir haciendo el chequeo semantico y detectar mas errores...
                ReturnType = record;
                return;
            }

            var definitionFields = record.Fields.ToList();
            var declarationFields = Fields.ToList();
            for (int i = 0; i < definitionFields.Count; i++) {
                var definitionField = definitionFields[i];
                var declarationField = declarationFields[i];
                
                //Si el nombre de los campos no coincide
                if (definitionField.Key != declarationField.FieldName) {
                    errors.Add(new MessageError(Line, Column, string.Format("Field {0} must have the name {1}", declarationField.FieldName, definitionField.Key)));
                    continue;
                }

                //Si el nombre de los campos coincide..
                //Chequeamos el valor que se le asignara al campo
                int errorsCount = errors.Count;
                declarationField.CheckSemantic(scope, errors);
                //Si ocurrio algun error
                if (errorsCount != errors.Count) {
                    continue;
                }
                
                //Comprobamos: 
                // - Que la expresion retorne algun valor
                ErrorsHelper.CheckIfReturnsValue(declarationField, errors,
                                                 string.Format(
                                                     "The expression to be assigned to field '{0}' must return a value",
                                                     declarationField.FieldName));
                
                // - Que el tipo que estamos asignando al campo coincida, o que si el tipo es 'nil', el tipo del campo lo acepte
                if (declarationField.ReturnType != definitionField.Value) {
                    //Si no pasa que el tipo es 'nil' y puede ser asignado (es decir, si el tipo no es 'nil', o si el tipo es 'nil' y no puede ser asignado
                    if (!(declarationField.ReturnType is NilType && NilType.CanBeAssignedTo(definitionField.Value))) {
                        errors.Add(new UnexpectedTypeError(Line, Column, declarationField.ReturnType, definitionField.Value));
                    }
                }
            }

            //Asignamos el tipo de retorno
            ReturnType = record;
        }
    }
}
