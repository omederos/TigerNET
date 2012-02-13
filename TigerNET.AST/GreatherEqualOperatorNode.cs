using System;

namespace TigerNET.AST {
    public class GreatherEqualOperatorNode : RelationalBinaryOperatorNode {
        public GreatherEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public GreatherEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}