using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class RecordAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo. Siempre conoceremos a quien se esta accediendo debido a la estructura
        /// de la gramatica, es decir, para llegar a instanciar esta clase (RecordAccessNode), es porque ya fue instanciada de antemano 'Left', lo que puede
        /// ser una variable (VariableAccessNode), un record (RecordAccessNode), una expresion cualquiera (segun los cambios hechos en las especificaciones del proyecto), etc.
        /// </summary>
        public ExpressionNode Left { get; set; }
        /// <summary>
        /// Campo al que se esta accediendo
        /// </summary>
        public string FieldName { get; set; }

        public RecordAccessNode(ExpressionNode left, string fieldName) {
            Left = left;
            FieldName = fieldName;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
