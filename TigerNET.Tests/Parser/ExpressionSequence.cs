using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class ExpressionSequence {
        [Test]
        public void Zero() {
            ExpressionNode ast = Utils.BuildAST("()");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            IList<ExpressionNode> seq = Utils.GetSequence(ast);
            Assert.AreEqual(seq.Count, 0);
        }

        [Test]
        public void One_Integer() {
            ExpressionNode ast = Utils.BuildAST("(1)");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            IList<ExpressionNode> seq = Utils.GetSequence(ast);
            Assert.AreEqual(seq.Count, 1);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[0]);
            Assert.That(seq[0].Parent == ast);
        }

        [Test]
        public void One_Callable() {
            ExpressionNode ast = Utils.BuildAST("(f(0))");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            IList<ExpressionNode> seq = Utils.GetSequence(ast);
            Assert.AreEqual(seq.Count, 1);
            Assert.IsInstanceOf<CallableNode>(seq[0]);
            Assert.That(seq[0].Parent == ast);
        }

        [Test]
        public void Two_Integer() {
            ExpressionNode ast = Utils.BuildAST("(1;2)");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            IList<ExpressionNode> seq = Utils.GetSequence(ast);
            Assert.AreEqual(seq.Count, 2);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[0]);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[1]);
            Assert.That(seq[0].Parent == ast);
            Assert.That(seq[1].Parent == ast);
        }

        [Test]
        public void Two_ExpressionSequences() {
            ExpressionNode ast = Utils.BuildAST("(();())");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            IList<ExpressionNode> seq = Utils.GetSequence(ast);
            Assert.AreEqual(seq.Count, 2);
            Assert.IsInstanceOf<ExpressionSequenceNode>(seq[0]);
            Assert.IsInstanceOf<ExpressionSequenceNode>(seq[1]);
            Assert.That(seq[0].Parent == ast);
            Assert.That(seq[1].Parent == ast);
        }
    }
}