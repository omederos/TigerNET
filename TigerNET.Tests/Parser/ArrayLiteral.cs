using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class ArrayLiteral
    {
        public ExpressionNode GetInitialExpression(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "InitialValue");
        }
        
        public ExpressionNode GetCountExpression(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "Count");
        }

        [Test]
        public void Zero_IntType()
        {
            var ast = Utils.BuildAST("array[0] of 1");
            Assert.IsInstanceOf<ArrayLiteralNode>(ast);
            var initial = GetInitialExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(initial);
            var count = GetCountExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(count);
        }

        [Test]
        public void Zero_ArrayType()
        {
            var ast = Utils.BuildAST("array[0] of array[0] of 1");
            Assert.IsInstanceOf<ArrayLiteralNode>(ast);
            var initial = GetInitialExpression(ast);
            Assert.IsInstanceOf<ArrayLiteralNode>(initial);
            var count = GetCountExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(count);

            var array2 = initial;
            var initial2 = GetInitialExpression(array2);
            var count2 = GetCountExpression(array2);

            Assert.IsInstanceOf<IntegerLiteralNode>(initial2);
            Assert.IsInstanceOf<IntegerLiteralNode>(count2);
        }
    }
}
