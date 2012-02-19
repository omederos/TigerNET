using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class While {
        [Test]
        public void Simple() {
            ExpressionNode ast = Utils.BuildAST("while 1 do 1");
            Assert.IsInstanceOf<WhileNode>(ast);
            ExpressionNode cond = Utils.GetCondition(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(cond);
            ExpressionNode body = Utils.GetBody(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }

        [Test]
        public void WhileInside() {
            ExpressionNode ast = Utils.BuildAST("while while 1 do 1 do 1");
            Assert.IsInstanceOf<WhileNode>(ast);
            ExpressionNode cond = Utils.GetCondition(ast);
            Assert.IsInstanceOf<WhileNode>(cond);
            ExpressionNode body = Utils.GetBody(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }
    }
}