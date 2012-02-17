using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class ExpressionSequence
    {
        private IList<ExpressionNode> GetSequence(ExpressionNode expr) {
            return Utils.GetProperty<IList<ExpressionNode>>(expr, "Sequence");
        }

        [Test]
        public void Zero()
        {
            var ast = Utils.BuildAST("()");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            var seq = GetSequence(ast);
            Assert.AreEqual(seq.Count, 0);
        }

        [Test]
        public void One_Integer()
        {
            var ast = Utils.BuildAST("(1)");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            var seq = GetSequence(ast);
            Assert.AreEqual(seq.Count, 1);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[0]);
        }

        [Test]
        public void One_Callable()
        {
            var ast = Utils.BuildAST("(f(0))");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            var seq = GetSequence(ast);
            Assert.AreEqual(seq.Count, 1);
            Assert.IsInstanceOf<CallableNode>(seq[0]);
        }
        
        [Test]
        public void Two_Integer()
        {
            var ast = Utils.BuildAST("(1;2)");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            var seq = GetSequence(ast);
            Assert.AreEqual(seq.Count, 2);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[0]);
            Assert.IsInstanceOf<IntegerLiteralNode>(seq[1]);
        }

        [Test]
        public void Two_ExpressionSequences()
        {
            var ast = Utils.BuildAST("(();())");
            Assert.IsInstanceOf<ExpressionSequenceNode>(ast);
            var seq = GetSequence(ast);
            Assert.AreEqual(seq.Count, 2);
            Assert.IsInstanceOf<ExpressionSequenceNode>(seq[0]);
            Assert.IsInstanceOf<ExpressionSequenceNode>(seq[1]);
        }


    }
}
