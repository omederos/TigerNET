using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    class RecordAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo. Siempre conoceremos a quien se esta accediendo debido a la estructura
        /// de la gramatica, es decir, para llegar a instanciar esta clase (AccessNode), es porque ya fue instanciada de antemano 'Left', lo que puede
        /// ser una variable (VariableAccessNode), un record (RecordAccessNode), etc.
        /// </summary>
        public AccessNode Left { get; set; }
        /// <summary>
        /// Campo al que se esta accediendo
        /// </summary>
        public string FieldName { get; set; }

        public RecordAccessNode(AccessNode left, string fieldName) {
            Left = left;
            FieldName = fieldName;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
