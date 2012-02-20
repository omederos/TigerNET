using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class GreatherOperatorNode : RelationalBinaryOperatorNode {
        public GreatherOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public GreatherOperatorNode() : this(null, null) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}