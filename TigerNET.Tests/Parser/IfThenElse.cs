using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    [TestFixture]
    public class IfThenElse
    {
        private ExpressionNode GetCondition(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "Condition");
        }
        private ExpressionNode GetThen(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "ThenBody");
        }
        private ExpressionNode GetElse(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "ElseBody");
        }

        [Test]
        public void WithoutElse() {
            var ast = Utils.BuildAST("if 0 then 0");
            Assert.IsInstanceOf<IfThenElseNode>(ast);
            var cond = GetCondition(ast);
            var then = GetThen(ast);
            var els = GetElse(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(cond);
            Assert.IsInstanceOf<IntegerLiteralNode>(then);
            Assert.AreEqual(els, null);
        }

        [Test]
        public void WithElse()
        {
            var ast = Utils.BuildAST("if 0 then 0 else 0");
            Assert.IsInstanceOf<IfThenElseNode>(ast);
            var cond = GetCondition(ast);
            var then = GetThen(ast);
            var els = GetElse(ast);
            Assert.IsInstanceOf<IntegerLiteralNode>(cond);
            Assert.IsInstanceOf<IntegerLiteralNode>(then);
            Assert.IsInstanceOf<IntegerLiteralNode>(els);
        }
    }
}
