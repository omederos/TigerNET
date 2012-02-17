using System;

namespace TigerNET.AST {
    public class IfThenElseNode : ControlNode{
        public ExpressionNode ElseBody { get; set; }
        public ExpressionNode ThenBody { get; set; }
        public ExpressionNode Condition { get; set; }

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