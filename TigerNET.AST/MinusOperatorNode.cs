using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class MinusOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public MinusOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public MinusOperatorNode() : this(null, null) {}
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
