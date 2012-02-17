using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class StringLiteral
    {
        private string GetValue(ExpressionNode expr)
        {
            return Utils.GetProperty<object>(expr, "Value").ToString();
        }

        [Test]
        public void WithSpaces()
        {
            var ast = Utils.BuildAST(@"""Oscar Mederos""");
            Assert.IsInstanceOf<StringLiteralNode>(ast);
            var value = GetValue(ast);
            Assert.AreEqual(value, "Oscar Mederos");
        }

        [Test]
        public void AllCharacters()
        {
            var ast = Utils.BuildAST(@"""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ""");
            Assert.IsInstanceOf<StringLiteralNode>(ast);
            var value = GetValue(ast);
            Assert.AreEqual(value, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }
    }
}
