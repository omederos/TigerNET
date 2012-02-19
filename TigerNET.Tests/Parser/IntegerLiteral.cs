using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class IntLiteral {
        [Test]
        public void Zero() {
            ExpressionNode ast = Utils.BuildAST("0");
            Assert.IsInstanceOf<IntegerLiteralNode>(ast);
            int value = Utils.GetIntValue(ast);
            Assert.AreEqual(value, 0);
        }

        [Test]
        public void SomeNumber() {
            ExpressionNode ast = Utils.BuildAST("12329832");
            Assert.IsInstanceOf<IntegerLiteralNode>(ast);
            int value = Utils.GetIntValue(ast);
            Assert.AreEqual(value, 12329832);
        }
    }
}