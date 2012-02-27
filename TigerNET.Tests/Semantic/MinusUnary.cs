using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class MinusUnary : SemanticTest
    {
        [Test]
        public void WrongType() {
            var ast = Utils.BuildAST(@"-""wrong type""");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }

        [Test]
        public void Integer()
        {
            var ast = Utils.BuildAST(@"-2");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void ExpressionSequence_LastIsInt()
        {
            var ast = Utils.BuildAST(@"-(""Pepe""; 2)");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        //TODO: Anadir mas pruebas unitarias con llamados a funciones, etc
    }
}
