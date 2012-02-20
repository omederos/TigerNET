using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

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

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
