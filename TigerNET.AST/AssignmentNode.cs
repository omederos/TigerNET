using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    /// <summary>
    /// Nodo que se usa para asignarle el valor de una expression a un campo de un record, valor de array, o variable ya existente
    /// </summary>
    public class AssignmentNode : AssignmentBaseNode
    {
        public AssignmentNode(AccessNode left, ExpressionNode body) : base(left, body) {}
        
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
