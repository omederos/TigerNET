using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class VariableAccess : SemanticTest
    {
        [Test]
        public void StringVar()
        {
            Scope.Add("x", StringType.Create());
            var ast = Utils.BuildAST(@"x");
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is StringType);
        }

        [Test]
        public void Plus_In_LetIn()
        {
            var ast = Utils.BuildAST(@"let var x := 10 in x + 2 end");
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void Undefined_Var()
        {
            var ast = Utils.BuildAST(@"let var x := 10 in y end");
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedVariableError);
        }

        [Test]
        public void Two_Scopes() {
            var s = new Scope();
            s.Add("x", StringType.Create());
            Scope.Parent = s;
            var ast = Utils.BuildAST(@"let var x := 10 in x + 2 end");
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }
    }
}
