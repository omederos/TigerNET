using System;

namespace TigerNET.AST {
    public class LowerEqualOperatorNode : RelationalBinaryOperatorNode {
        public LowerEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}