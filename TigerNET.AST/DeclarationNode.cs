using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;

namespace TigerNET.AST
{
    public abstract class DeclarationNode : ExpressionNode
    {
        protected DeclarationNode(string name) {
            Name = name;
        }
        /// <summary>
        /// Nombre de la variable
        /// </summary>
        public string Name { get; private set; }
    }
}
