using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class ArithmeticalBinaryOperators {
        [Test]
        public void Plus() {
            ExpressionNode ast = Utils.BuildAST("0+0");
            Assert.IsInstanceOf<PlusOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            ExpressionNode right = Utils.GetRight(ast);
            Assert.That(left.Parent == ast);
            Assert.That(right.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Minus() {
            ExpressionNode ast = Utils.BuildAST("0-0");
            Assert.IsInstanceOf<MinusOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            ExpressionNode right = Utils.GetRight(ast);
            Assert.That(left.Parent == ast);
            Assert.That(right.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Prod() {
            ExpressionNode ast = Utils.BuildAST("0*0");
            Assert.IsInstanceOf<ProdOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            ExpressionNode right = Utils.GetRight(ast);
            Assert.That(left.Parent == ast);
            Assert.That(right.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void Div() {
            ExpressionNode ast = Utils.BuildAST("0/0");
            Assert.IsInstanceOf<DivOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            ExpressionNode right = Utils.GetRight(ast);
            Assert.That(left.Parent == ast);
            Assert.That(right.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right);
        }

        [Test]
        public void OperatorOrders() {
            ExpressionNode ast = Utils.BuildAST("0+1*2-3");
            Assert.IsInstanceOf<PlusOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            ExpressionNode right = Utils.GetRight(ast);
            Assert.That(left.Parent == ast);
            Assert.That(right.Parent == ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(left);
            Assert.IsInstanceOf<MinusOperatorNode>(right);
            ExpressionNode left_1 = Utils.GetLeft(right);
            ExpressionNode right_1 = Utils.GetRight(right);
            Assert.That(left_1.Parent == right);
            Assert.That(right_1.Parent == right);
            Assert.IsInstanceOf<ProdOperatorNode>(left_1);
            Assert.IsInstanceOf<IntegerLiteralNode>(right_1);
        }

        [Test]
        public void OperatorOrders_WithPharentesis() {
            ExpressionNode ast = Utils.BuildAST("(0+1)*2-3");
            Assert.IsInstanceOf<MinusOperatorNode>(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            Assert.That(left.Parent == ast);
            Assert.IsInstanceOf<ProdOperatorNode>(left);
            ExpressionNode left_1 = Utils.GetLeft(left);
            Assert.That(left_1.Parent == left);
            ExpressionNode right_1 = Utils.GetRight(left);
            Assert.That(right_1.Parent == left);
            Assert.IsInstanceOf<IntegerLiteralNode>(right_1);
            Assert.IsInstanceOf<ExpressionSequenceNode>(left_1);
            var sequence = Utils.GetProperty<IList<ExpressionNode>>(left_1, "Sequence");
            Assert.AreEqual(sequence.Count, 1);
            ExpressionNode first = sequence[0];
            Assert.That(first.Parent == left_1);
            Assert.IsInstanceOf<PlusOperatorNode>(first);
        }
    }
}