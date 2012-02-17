using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class VariableDeclaration
    {
        private ExpressionNode GetFirstDeclaration(ExpressionNode expr)
        {
            return ((LetInEndNode)expr).Declarations[0];
        }

        private string GetName(ExpressionNode expr)
        {
            return Utils.GetProperty<string>(expr, "Name");
        }

        private string GetType(ExpressionNode expr)
        {
            return Utils.GetProperty<string>(expr, "Type");
        }

        private ExpressionNode GetBody(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "Body");
        }

        [Test]
        public void WithType()
        {
            var ast = Utils.BuildAST("let var a : int := 1+2 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<VariableDeclarationNode>(dec);
            var name = GetName(dec);
            var type = GetType(dec);
            var body = GetBody(dec);
            Assert.AreEqual(name, "a");
            Assert.AreEqual(type, "int");
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void WithoutType()
        {
            var ast = Utils.BuildAST("let var a := 1+2 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<VariableDeclarationNode>(dec);
            var name = GetName(dec);
            var type = GetType(dec);
            var body = GetBody(dec);
            Assert.AreEqual(name, "a");
            Assert.AreEqual(type, null);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }
    }
}
