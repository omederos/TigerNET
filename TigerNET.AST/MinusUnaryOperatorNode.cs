using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class MinusUnaryOperatorNode : UnaryOperatorNode
    {
        public MinusUnaryOperatorNode(ExpressionNode body) : base(body) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
