using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class ForToDo
    {
        public string GetVariableName(ExpressionNode expr) {
            return Utils.GetProperty<string>(expr, "VariableName");
        }
        public ExpressionNode GetExpressionInitial(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "ExpressionInitial");
        }
        public ExpressionNode GetExpressionFinal(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "ExpressionFinal");
        }
        public ExpressionNode GetBody(ExpressionNode expr) {
            return Utils.GetProperty<ExpressionNode>(expr, "Body");
        }

        [Test]
        public void ForToDo_Medium()
        {
            var ast = Utils.BuildAST("for abc := 1+2+3 to () do (a+b+c)");
            Assert.IsInstanceOf<ForToDoNode>(ast);
            var variableName = GetVariableName(ast);
            var initial = GetExpressionInitial(ast);
            var final = GetExpressionFinal(ast);
            var body = GetBody(ast);
            Assert.AreEqual(variableName, "abc");
            Assert.IsInstanceOf<PlusOperatorNode>(initial);
            Assert.IsInstanceOf<ExpressionSequenceNode>(final);
            Assert.IsInstanceOf<ExpressionSequenceNode>(body);
        }
    }
}
