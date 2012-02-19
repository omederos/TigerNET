using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class ForToDo {
        [Test]
        public void ForToDo_Medium() {
            ExpressionNode ast = Utils.BuildAST("for abc := 1+2+3 to () do (a+b+c)");
            Assert.IsInstanceOf<ForToDoNode>(ast);
            string variableName = Utils.GetVariableName(ast);
            ExpressionNode initial = Utils.GetExpressionInitial(ast);
            ExpressionNode final = Utils.GetExpressionFinal(ast);
            ExpressionNode body = Utils.GetBody(ast);
            Assert.AreEqual(variableName, "abc");
            Assert.IsInstanceOf<PlusOperatorNode>(initial);
            Assert.IsInstanceOf<ExpressionSequenceNode>(final);
            Assert.IsInstanceOf<ExpressionSequenceNode>(body);
        }
    }
}