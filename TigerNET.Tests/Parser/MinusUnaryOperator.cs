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

        [Test]
        public void MinusAndEquals_Preference() {
            ExpressionNode ast = Utils.BuildAST("-3 = 3");
            Assert.IsInstanceOf<EqualOperatorNode>(ast);
            var left = Utils.GetLeft(ast);
            Assert.IsInstanceOf<MinusUnaryOperatorNode>(left);
            var right = Utils.GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
            
        }
    }
}