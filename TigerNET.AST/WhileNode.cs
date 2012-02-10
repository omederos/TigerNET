using System;

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

        public override void CheckSemantic()
        {
            throw new NotImplementedException();
        }
    }
}