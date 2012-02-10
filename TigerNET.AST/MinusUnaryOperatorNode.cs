using System;

namespace TigerNET.AST
{
    public class MinusUnaryOperatorNode : UnaryOperatorNode
    {
        public MinusUnaryOperatorNode(ExpressionNode body) : base(body) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
