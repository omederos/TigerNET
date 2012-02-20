using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    /// <summary>
    /// Nodo que se usa para asignarle el valor de una expression a un campo de un record, valor de array, o variable ya existente
    /// </summary>
    public class AssignmentNode : AssignmentBaseNode
    {
        /// <summary>
        /// Nodo al que le estamos asignando el valor. Puede ser una variable, posicion de array, campo de un record..
        /// </summary>
        public AccessNode Left { get; set; }

        public AssignmentNode(AccessNode left, ExpressionNode body) : base(body) {
            Left = left;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
