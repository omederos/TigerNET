using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class MinusUnaryOperator
    {
        private ExpressionNode GetBody(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "Body");
        }

        [Test]
        public void Zero()
        {
            var ast = Utils.BuildAST("-0");
            Assert.IsInstanceOf<MinusUnaryOperatorNode>(ast);
            var body = GetBody(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }
    }
}
