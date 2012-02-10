using System;

namespace TigerNET.AST {
    public class IfThenElseNode : ControlNode{
        protected ExpressionNode ElseBody { get; set; }
        protected ExpressionNode ThenBody { get; set; }
        protected ExpressionNode Condition { get; set; }

        public IfThenElseNode(ExpressionNode condition, ExpressionNode thenBody, ExpressionNode elseBody) {
            Condition = condition;
            ThenBody = thenBody;
            ElseBody = elseBody;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}