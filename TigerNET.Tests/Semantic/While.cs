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
    public class While : SemanticTest
    {
        [Test]
        public void While_OK()
        {
            var ast = Utils.BuildAST("while 1 do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }

        [Test]
        public void While_NoIntCondition()
        {
            var ast = Utils.BuildAST(@"while ""hello"" do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void While_NoValueCondition()
        {
            var ast = Utils.BuildAST(@"while () do ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }
        
        [Test]
        public void While_BodyReturnsValue()
        {
            var ast = Utils.BuildAST(@"while 0 do 1");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

    }
}
