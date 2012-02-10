using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class VariableAccessNode : AccessNode
    {
        /// <summary>
        /// Nombre de la variable a la que se esta accediendo
        /// </summary>
        public string Name { get; set; }

        public VariableAccessNode(string name) {
            Name = name;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
