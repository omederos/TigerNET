using System;

namespace TigerNET.AST {
    public class LowerOperatorNode : RelationalBinaryOperatorNode {
        public LowerOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}