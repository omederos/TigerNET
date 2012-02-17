using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class IntLiteral
    {
        private int GetValue(ExpressionNode expr)
        {
            return int.Parse(Utils.GetProperty<object>(expr, "Value").ToString());
        }

        [Test]
        public void Zero()
        {
            var ast = Utils.BuildAST("0");
            Assert.IsInstanceOf<IntegerLiteralNode>(ast);
            var value = GetValue(ast);
            Assert.AreEqual(value, 0);
        }

        [Test]
        public void SomeNumber()
        {
            var ast = Utils.BuildAST("12329832");
            Assert.IsInstanceOf<IntegerLiteralNode>(ast);
            var value = GetValue(ast);
            Assert.AreEqual(value, 12329832);
        }
    }
}
