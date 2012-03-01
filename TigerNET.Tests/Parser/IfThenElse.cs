using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    [TestFixture]
    public class IfThenElse {
        [Test]
        public void WithElse() {
            ExpressionNode ast = Utils.BuildAST("if 0 then 0 else 0");
            Assert.IsInstanceOf<IfThenElseNode>(ast);
            ExpressionNode cond = Utils.GetCondition(ast);
            ExpressionNode then = Utils.GetThen(ast);
            ExpressionNode els = Utils.GetElse(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(cond);
            Assert.IsInstanceOf<IntegerLiteralNode>(then);
            Assert.IsInstanceOf<IntegerLiteralNode>(els);
            Assert.That(cond.Parent == ast);
            Assert.That(then.Parent == ast);
            Assert.That(els.Parent == ast);

        }

        [Test]
        public void WithoutElse() {
            ExpressionNode ast = Utils.BuildAST("if 0 then 0");
            Assert.IsInstanceOf<IfThenElseNode>(ast);
            ExpressionNode cond = Utils.GetCondition(ast);
            ExpressionNode then = Utils.GetThen(ast);
            ExpressionNode els = Utils.GetElse(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(cond);
            Assert.IsInstanceOf<IntegerLiteralNode>(then);
            Assert.AreEqual(els, null);
            Assert.That(cond.Parent == ast);
            Assert.That(then.Parent == ast);
        }
    }
}