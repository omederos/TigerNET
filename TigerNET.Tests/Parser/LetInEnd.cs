using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class LetInEnd {
        [Test]
        public void TwoDeclarations_NoExpressions() {
            ExpressionNode ast = Utils.BuildAST("let var a := 1 var b := 2 in end");
            Assert.IsInstanceOf<LetInEndNode>(ast);
            IList<DeclarationNode> declarations = Utils.GetDeclarations(ast);
            Assert.AreEqual(declarations.Count, 2);
            Assert.IsInstanceOf<VariableDeclarationNode>(declarations[0]);
            Assert.IsInstanceOf<VariableDeclarationNode>(declarations[1]);
        }

        [Test]
        public void OneDeclaration_NoExpressions() {
            ExpressionNode ast = Utils.BuildAST("let var a := 1 in end");
            Assert.IsInstanceOf<LetInEndNode>(ast);
            IList<DeclarationNode> declarations = Utils.GetDeclarations(ast);
            Assert.AreEqual(declarations.Count, 1);
            Assert.IsInstanceOf<VariableDeclarationNode>(declarations[0]);
        }

        [Test]
        public void OneDeclaration_OneExpressions() {
            ExpressionNode ast = Utils.BuildAST("let var a := 1 in f(0) end");
            Assert.IsInstanceOf<LetInEndNode>(ast);
            IList<DeclarationNode> declarations = Utils.GetDeclarations(ast);
            Assert.AreEqual(declarations.Count, 1);
            Assert.IsInstanceOf<VariableDeclarationNode>(declarations[0]);
            ExpressionSequenceNode expressions = Utils.GetExpressions(ast);
            Assert.AreEqual(expressions.Sequence.Count, 1);
            Assert.IsInstanceOf<CallableNode>(expressions.Sequence[0]);
        }

        [Test]
        public void OneDeclaration_TwoExpressions() {
            ExpressionNode ast = Utils.BuildAST("let var a := 1 in f(0);f(1) end");
            Assert.IsInstanceOf<LetInEndNode>(ast);
            IList<DeclarationNode> declarations = Utils.GetDeclarations(ast);
            Assert.AreEqual(declarations.Count, 1);
            Assert.IsInstanceOf<VariableDeclarationNode>(declarations[0]);
            ExpressionSequenceNode expressions = Utils.GetExpressions(ast);
            Assert.AreEqual(expressions.Sequence.Count, 2);
            Assert.IsInstanceOf<CallableNode>(expressions.Sequence[0]);
            Assert.IsInstanceOf<CallableNode>(expressions.Sequence[1]);
        }
    }
}