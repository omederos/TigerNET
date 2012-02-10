using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class MinusOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public MinusOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
