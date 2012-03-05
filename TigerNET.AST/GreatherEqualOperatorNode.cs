using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class GreatherEqualOperatorNode : RelationalBinaryOperatorNode {
        public GreatherEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, ">=") {}
        public GreatherEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }
    }
}