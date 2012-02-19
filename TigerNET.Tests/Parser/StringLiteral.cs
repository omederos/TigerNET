using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class StringLiteral {
        [Test]
        public void WithSpaces() {
            ExpressionNode ast = Utils.BuildAST(@"""Oscar Mederos""");
            Assert.IsInstanceOf<StringLiteralNode>(ast);
            string value = Utils.GetValue(ast);
            Assert.AreEqual(value, "Oscar Mederos");
        }

        [Test]
        public void AllCharacters() {
            ExpressionNode ast = Utils.BuildAST(@"""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ""");
            Assert.IsInstanceOf<StringLiteralNode>(ast);
            string value = Utils.GetValue(ast);
            Assert.AreEqual(value, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }
    }
}