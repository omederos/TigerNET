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
    public class IfThenElse : SemanticTest
    {
        [Test]
        public void NoElse_OK()
        {
            var ast = Utils.BuildAST("if 1 < 2 then ()");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }

        [Test]
        public void NoElse_ThenReturningValue()
        {
            var ast = Utils.BuildAST("if 1 < 2 then 0");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void Else_DifferentTypes()
        {
            var ast = Utils.BuildAST(@"if 1 < 2 then 0 else ""Hello""");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }
        [Test]
        public void Else_SameTypes_OK()
        {
            var ast = Utils.BuildAST("if 1 < 2 then 0 else 1");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }
        [Test]
        public void Else_NoReturn_OK()
        {
            var ast = Utils.BuildAST("if 1 < 2 then () else (2;())");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }

    }
}
