using System;

namespace TigerNET.AST {
    public class GreatherOperatorNode : RelationalBinaryOperatorNode {
        public GreatherOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public GreatherOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}