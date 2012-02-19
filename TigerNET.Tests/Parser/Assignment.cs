using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    public class Assignment
    {
        [Test]
        public void Assignment_Variable_Int()
        {
            ExpressionNode ast = Utils.BuildAST("x := 2");
            Assert.IsInstanceOf<AssignmentNode>(ast);

            var leftAccessNode = Utils.GetLeftAccessNode(ast);
            var body = Utils.GetBody(ast);

            Assert.IsInstanceOf<VariableAccessNode>(leftAccessNode);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }

        [Test]
        public void Assignment_ArrayPosition_Int()
        {
            ExpressionNode ast = Utils.BuildAST("x[0] := 2");
            Assert.IsInstanceOf<AssignmentNode>(ast);

            var leftAccessNode = Utils.GetLeftAccessNode(ast);
            var body = Utils.GetBody(ast);

            Assert.IsInstanceOf<ArrayAccessNode>(leftAccessNode);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }

        [Test]
        public void Assignment_RecordField_Int()
        {
            ExpressionNode ast = Utils.BuildAST("x.y := 2");
            Assert.IsInstanceOf<AssignmentNode>(ast);

            var leftAccessNode = Utils.GetLeftAccessNode(ast);
            var body = Utils.GetBody(ast);

            Assert.IsInstanceOf<RecordAccessNode>(leftAccessNode);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }

        [Test]
        public void Assignment_ArrayTwoPosition_Int()
        {
            ExpressionNode ast = Utils.BuildAST("x[0][1].y := 2");
            Assert.IsInstanceOf<AssignmentNode>(ast);

            var leftAccessNode = Utils.GetLeftAccessNode(ast);
            var body = Utils.GetBody(ast);

            Assert.IsInstanceOf<RecordAccessNode>(leftAccessNode);
            var left = Utils.GetLeft(leftAccessNode);
            Assert.IsInstanceOf<ArrayAccessNode>(left);
            var left2 = Utils.GetLeft(leftAccessNode);
            Assert.IsInstanceOf<ArrayAccessNode>(left2);
            Assert.IsInstanceOf<IntegerLiteralNode>(body);
        }
    }
}
