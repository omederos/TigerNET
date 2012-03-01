using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class Access {
        #region VariableAccessNode

        [Test]
        public void VariableAccessNode_X() {
            ExpressionNode ast = Utils.BuildAST("x");
            Assert.IsInstanceOf<VariableAccessNode>(ast);
            Assert.That(ast.Parent == null);
            string name = Utils.GetName(ast);
            Assert.AreEqual(name, "x");
        }

        #endregion

        #region RecordAccessNode

        [Test]
        public void RecordAccessNode_AccessToVariableField() {
            ExpressionNode ast = Utils.BuildAST("x.y");
            Assert.IsInstanceOf<RecordAccessNode>(ast);
            string fieldName = Utils.GetFieldName(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            Assert.That(left.Parent == ast);
            Assert.AreEqual(fieldName, "y");
            Assert.IsInstanceOf<VariableAccessNode>(left);
        }

        [Test]
        public void RecordAccessNode_AccessFunctionField() {
            ExpressionNode ast = Utils.BuildAST("f(0).y");
            Assert.IsInstanceOf<RecordAccessNode>(ast);
            string fieldName = Utils.GetFieldName(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.AreEqual(fieldName, "y");
            Assert.IsInstanceOf<CallableNode>(left);
        }

        [Test]
        public void RecordAccessNode_AccessExpressionSequence() {
            ExpressionNode ast = Utils.BuildAST("(a;b;c).y");
            Assert.IsInstanceOf<RecordAccessNode>(ast);
            string fieldName = Utils.GetFieldName(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.AreEqual(fieldName, "y");
            Assert.IsInstanceOf<ExpressionSequenceNode>(left);
        }

        #endregion

        #region ArrayAccessNode

        [Test]
        public void ArrayAccessNode_Field_Int() {
            ExpressionNode ast = Utils.BuildAST("x[0]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);
            Assert.That(index.Parent == ast);
            Assert.That(left.Parent == ast);

            Assert.IsInstanceOf<VariableAccessNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(index);
        }

        [Test]
        public void ArrayAccessNode_Field_Sum() {
            ExpressionNode ast = Utils.BuildAST("x[1+2]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.IsInstanceOf<VariableAccessNode>(left);
            Assert.IsInstanceOf<PlusOperatorNode>(index);
        }

        [Test]
        public void ArrayAccessNode_Field_Func() {
            ExpressionNode ast = Utils.BuildAST("x[f(0)]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.IsInstanceOf<VariableAccessNode>(left);
            Assert.IsInstanceOf<CallableNode>(index);
        }

        [Test]
        public void ArrayAccessNode_Func_Int() {
            ExpressionNode ast = Utils.BuildAST("f(0)[0]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.IsInstanceOf<CallableNode>(left);
            Assert.IsInstanceOf<IntegerLiteralNode>(index);
        }

        [Test]
        public void ArrayAccessNode_Func_Sum() {
            ExpressionNode ast = Utils.BuildAST("f(0)[1+2]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.IsInstanceOf<CallableNode>(left);
            Assert.IsInstanceOf<PlusOperatorNode>(index);
        }

        [Test]
        public void ArrayAccessNode_Func_Func() {
            ExpressionNode ast = Utils.BuildAST("f(0)[f(0)]");
            Assert.IsInstanceOf<ArrayAccessNode>(ast);
            ExpressionNode index = Utils.GetIndex(ast);
            ExpressionNode left = Utils.GetLeft(ast);

            Assert.IsInstanceOf<CallableNode>(left);
            Assert.IsInstanceOf<CallableNode>(index);
        }

        #endregion
    }
}