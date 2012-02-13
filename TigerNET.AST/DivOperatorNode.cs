using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class DivOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public DivOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public DivOperatorNode() : base(null, null) {}
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
