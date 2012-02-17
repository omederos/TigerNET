using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class ArithmeticalBinaryOperators
    {
        private ExpressionNode GetLeft(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "Left");
        }
        private ExpressionNode GetRight(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "Right");
        }

        [Test]
        public void Plus()
        {
            var ast = Utils.BuildAST("0+0");
            Assert.IsInstanceOf<PlusOperatorNode>(ast);
            var left = GetLeft(ast);
            var right = GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Minus()
        {
            var ast = Utils.BuildAST("0-0");
            Assert.IsInstanceOf<MinusOperatorNode>(ast);
            var left = GetLeft(ast);
            var right = GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Prod()
        {
            var ast = Utils.BuildAST("0*0");
            Assert.IsInstanceOf<ProdOperatorNode>(ast);
            var left = GetLeft(ast);
            var right = GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Div()
        {
            var ast = Utils.BuildAST("0/0");
            Assert.IsInstanceOf<DivOperatorNode>(ast);
            var left = GetLeft(ast);
            var right = GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void OperatorOrders()
        {
            var ast = Utils.BuildAST("0+1*2-3");
            Assert.IsInstanceOf<PlusOperatorNode>(ast);
            var left = GetLeft(ast);
            var right = GetRight(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<MinusOperatorNode>(right);
            var left_1 = GetLeft(right);
            var right_1 = GetRight(right);
            Assert.IsInstanceOf<ProdOperatorNode>(left_1);
            Assert.IsInstanceOf<IntegerLiteralNode>(right_1);
        }

        [Test]
        public void OperatorOrders_WithPharentesis()
        {
            var ast = Utils.BuildAST("(0+1)*2-3");
            Assert.IsInstanceOf<MinusOperatorNode>(ast);
            var left = GetLeft(ast);
            Assert.IsInstanceOf<ProdOperatorNode>(left);
            var left_1 = GetLeft(left);
            var right_1 = GetRight(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right_1);
            Assert.IsInstanceOf<ExpressionSequenceNode>(left_1);
            var sequence = Utils.GetProperty<IList<ExpressionNode>>(left_1, "Sequence");
            Assert.AreEqual(sequence.Count, 1);
            var first = sequence[0];
            Assert.IsInstanceOf<PlusOperatorNode>(first);
        }
    }
}
