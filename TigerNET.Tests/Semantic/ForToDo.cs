using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class ForToDo : SemanticTest
    {
        [Test]
        public void For_OK()
        {
            var ast = Utils.BuildAST("for i := 1 to 10 do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }
        [Test]
        public void For_IncorrectInitial()
        {
            var ast = Utils.BuildAST(@"for i := ""hello"" to 10 do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(!ast.ReturnsValue());
        }
        [Test]
        public void For_IncorrectFinal()
        {
            var ast = Utils.BuildAST(@"for i := 0 to ""hello"" do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(!ast.ReturnsValue());
        }
        
        [Test]
        public void For_BodyReturnsValue()
        {
            var ast = Utils.BuildAST(@"for i := -10 to 10 do 1");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(!ast.ReturnsValue());
        }

        [Test]
        public void AssignValueToForVariable()
        {
            var ast = Utils.BuildAST(@"for i := -10 to 10 do i := 0");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(!ast.ReturnsValue());
        }
    }
}
