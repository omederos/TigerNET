using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class NotEqualOperatorNode : RelationalBinaryOperatorNode {
        public NotEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "<>") {}

        public NotEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }
    }
}