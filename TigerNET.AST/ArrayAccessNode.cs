using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class ArrayAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo
        /// </summary>
        public AccessNode Left { get; set; }
        /// <summary>
        /// Expression con tipo de retorno entero que indica al indice del array que se accedera
        /// </summary>
        public ExpressionNode Index { get; set; }

        public ArrayAccessNode(AccessNode left, ExpressionNode index) {
            Left = left;
            Index = index;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
