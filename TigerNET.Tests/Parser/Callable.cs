using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class Callable {
        [Test]
        public void ZeroParameters() {
            ExpressionNode ast = Utils.BuildAST("f()");
            Assert.IsInstanceOf<CallableNode>(ast);
            string name = Utils.GetName(ast);
            Assert.AreEqual(name, "f");
            IList<ExpressionNode> parameters = Utils.GetParameters(ast);
            Assert.AreEqual(parameters.Count, 0);
            Assert.That(ParentIs(parameters, ast));
        }

        private bool ParentIs(IList<ExpressionNode> parameters, ExpressionNode parent ) {
            return parameters.All(p => p.Parent == parent);
        }

        [Test]
        public void OneParameter_Int() {
            ExpressionNode ast = Utils.BuildAST("f(1)");
            Assert.IsInstanceOf<CallableNode>(ast);
            string name = Utils.GetName(ast);
            Assert.AreEqual(name, "f");
            IList<ExpressionNode> parameters = Utils.GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<IntegerLiteralNode>(parameters[0]);
            Assert.That(ParentIs(parameters, ast));
        }

        [Test]
        public void OneParameter_Function() {
            ExpressionNode ast = Utils.BuildAST("f(g())");
            Assert.IsInstanceOf<CallableNode>(ast);
            string name = Utils.GetName(ast);
            Assert.AreEqual(name, "f");
            IList<ExpressionNode> parameters = Utils.GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<CallableNode>(parameters[0]);
            Assert.That(ParentIs(parameters, ast));
        }

        [Test]
        public void OneParameter_FunctionWithParameters() {
            ExpressionNode ast = Utils.BuildAST("f(g(1,2))");
            Assert.IsInstanceOf<CallableNode>(ast);
            string name = Utils.GetName(ast);
            Assert.AreEqual(name, "f");
            IList<ExpressionNode> parameters = Utils.GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<CallableNode>(parameters[0]);
            IList<ExpressionNode> parameters2 = Utils.GetParameters(parameters[0]);
            Assert.AreEqual(parameters2.Count, 2);
            Assert.That(ParentIs(parameters, ast));
        }
    }
}