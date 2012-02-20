using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class WhileNode : ControlNode
    {
        public ExpressionNode Condition { get; set; }
        public ExpressionNode Body { get; set; }

        public WhileNode(ExpressionNode condition, ExpressionNode body) {
            Condition = condition;
            Body = body;
        }

        public override void GenerateCode()
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors)
        {
            throw new NotImplementedException();
        }
    }
}