using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class ArrayAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo
        /// </summary>
        public ExpressionNode Left { get; set; }
        /// <summary>
        /// Expression con tipo de retorno entero que indica al indice del array que se accedera
        /// </summary>
        public ExpressionNode Index { get; set; }

        public ArrayAccessNode(ExpressionNode left, ExpressionNode index) {
            Left = left;
            Index = index;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
