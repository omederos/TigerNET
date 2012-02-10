using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public abstract class AssignmentBaseNode : ExpressionNode
    {
        /// <summary>
        /// Donde guardaremos el valor de la asignacion (parte izquierda)
        /// </summary>
        public AccessNode Left { get; set; }
        /// <summary>
        /// Valor que guardaremos
        /// </summary>
        public ExpressionNode Body { get; set; }

        protected AssignmentBaseNode(AccessNode left, ExpressionNode body ) {
            Left = left;
            Body = body;
        }
    }
}
