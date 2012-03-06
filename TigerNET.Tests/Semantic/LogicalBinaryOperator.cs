using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    class LogicalBinaryOperator : SemanticTest
    {
        [Test]
        public void And_Int_Int() {
            var ast = Utils.BuildAST("0 & 0");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }
        [Test]
        public void And_String_Int() {
            var ast = Utils.BuildAST(@"""Oscar"" & 0");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }
    }
}
