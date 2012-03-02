using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class NotEqualOperatorNode : RelationalBinaryOperatorNode {
        public NotEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "<>") {
            AllowedTypes.Add(typeof(RecordType));
            AllowedTypes.Add(typeof(ArrayType));
        }

        public NotEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }
    }
}