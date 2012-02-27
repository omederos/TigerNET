using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class GreatherEqualOperatorNode : RelationalBinaryOperatorNode {
        public GreatherEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, ">=") {}
        public GreatherEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }
    }
}