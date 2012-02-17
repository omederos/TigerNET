using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class Callable
    {
        public string GetName(ExpressionNode expr) {
            return Utils.GetProperty<string>(expr, "Name");
        }

        public IList<ExpressionNode> GetParameters(ExpressionNode expr)
        {
            return Utils.GetProperty<IList<ExpressionNode>>(expr, "Parameters");
        }

        [Test]
        public void ZeroParameters()
        {
            var ast = Utils.BuildAST("f()");
            Assert.IsInstanceOf<CallableNode>(ast);
            var name = GetName(ast);
            Assert.AreEqual(name, "f");
            var parameters = GetParameters(ast);
            Assert.AreEqual(parameters.Count, 0);
        }

        [Test]
        public void OneParameter_Int()
        {
            var ast = Utils.BuildAST("f(1)");
            Assert.IsInstanceOf<CallableNode>(ast);
            var name = GetName(ast);
            Assert.AreEqual(name, "f");
            var parameters = GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<IntegerLiteralNode>(parameters[0]);
        }

        [Test]
        public void OneParameter_Function()
        {
            var ast = Utils.BuildAST("f(g())");
            Assert.IsInstanceOf<CallableNode>(ast);
            var name = GetName(ast);
            Assert.AreEqual(name, "f");
            var parameters = GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<CallableNode>(parameters[0]);
        }

        [Test]
        public void OneParameter_FunctionWithParameters()
        {
            var ast = Utils.BuildAST("f(g(1,2))");
            Assert.IsInstanceOf<CallableNode>(ast);
            var name = GetName(ast);
            Assert.AreEqual(name, "f");
            var parameters = GetParameters(ast);
            Assert.AreEqual(parameters.Count, 1);
            Assert.IsInstanceOf<CallableNode>(parameters[0]);
            var parameters2 = GetParameters(parameters[0]);
            Assert.AreEqual(parameters2.Count, 2);
        }
    }
}
