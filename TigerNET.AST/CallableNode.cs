using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class CallableNode : InstructionNode
    {
        public string Name { get; set; }
        public IList<ExpressionNode> Parameters { get; set; }

        public CallableNode(string name, IList<ExpressionNode> parameters) {
            Name = name;
            Parameters = parameters;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
