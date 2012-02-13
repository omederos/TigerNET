using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public abstract class AssignmentBaseNode : ExpressionNode
    {
        /// <summary>
        /// Valor que guardaremos
        /// </summary>
        public ExpressionNode Body { get; set; }

        protected AssignmentBaseNode(ExpressionNode body ) {
            Body = body;
        }
    }
}
