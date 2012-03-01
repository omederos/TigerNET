using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class MinusUnaryOperator {
        [Test]
        public void Zero() {
            ExpressionNode ast = Utils.BuildAST("-0");
            Assert.IsInstanceOf<MinusUnaryOperatorNode>(ast);
            ExpressionNode body = Utils.GetBody(ast);
            Assert.That(body.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }
    }
}