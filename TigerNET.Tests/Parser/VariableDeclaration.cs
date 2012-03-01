using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class VariableDeclaration {
        [Test]
        public void WithType() {
            ExpressionNode ast = Utils.BuildAST("let var a : int := 1+2 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<VariableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            Assert.That(body.Parent == dec);
            Assert.AreEqual(name, "a");
            Assert.AreEqual(type, "int");
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void WithoutType() {
            ExpressionNode ast = Utils.BuildAST("let var a := 1+2 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<VariableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            Assert.That(body.Parent == dec);
            Assert.AreEqual(name, "a");
            Assert.AreEqual(type, null);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }
    }
}