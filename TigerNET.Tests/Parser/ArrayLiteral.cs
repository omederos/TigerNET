using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class ArrayLiteral {
        [Test]
        public void Zero_IntType() {
            ExpressionNode ast = Utils.BuildAST("array[0] of 1");
            Assert.IsInstanceOf<ArrayLiteralNode>(ast);
            ExpressionNode initial = Utils.GetInitialExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(initial);
            ExpressionNode count = Utils.GetCountExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(count);
        }

        [Test]
        public void Zero_ArrayType() {
            ExpressionNode ast = Utils.BuildAST("array[0] of array[0] of 1");
            Assert.IsInstanceOf<ArrayLiteralNode>(ast);
            ExpressionNode initial = Utils.GetInitialExpression(ast);
            Assert.IsInstanceOf<ArrayLiteralNode>(initial);
            ExpressionNode count = Utils.GetCountExpression(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(count);

            ExpressionNode array2 = initial;
            ExpressionNode initial2 = Utils.GetInitialExpression(array2);
            ExpressionNode count2 = Utils.GetCountExpression(array2);

            Assert.IsInstanceOf<IntegerLiteralNode>(initial2);
            Assert.IsInstanceOf<IntegerLiteralNode>(count2);
        }
    }
}