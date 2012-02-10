using System;

namespace TigerNET.AST {
    public class ForToDoNode : ControlNode
    {
        public ExpressionNode ExpressionInitial { get; set; }
        public ExpressionNode ExpressionFinal { get; set; }
        public ExpressionNode Body { get; set; }

        public ForToDoNode(ExpressionNode expressionInitial, ExpressionNode expressionFinal, ExpressionNode Body) {
            ExpressionInitial = expressionInitial;
            ExpressionFinal = expressionFinal;
            this.Body = Body;
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