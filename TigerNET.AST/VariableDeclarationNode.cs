using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class VariableDeclarationNode : DeclarationNode
    {
        public ExpressionNode Body { get; set; }
        public string Type { get; set; }

        public VariableDeclarationNode(string name, ExpressionNode body, string type = null) : base(name) {
            Body = body;
            Type = type;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
