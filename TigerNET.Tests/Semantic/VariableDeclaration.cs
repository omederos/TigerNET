﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class SemanticTest {
        protected Scope Scope;
        protected IList<Error> Errors;

        [SetUp]
        public void Init()
        {
            Scope = new Scope();
            Errors = new List<Error>();
        }
    }

    public class VariableDeclaration : SemanticTest
    {
        [Test]
        public void String() {
            var ast = Utils.BuildAST(@"let var x := ""abc"" in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(Scope.DefinedVariables.Count == 1);
            Assert.That(Scope.ExistsDeclaration("x"));
            Assert.IsInstanceOf<StringType>(Scope.DefinedVariables["x"]);
        }

        [Test]
        public void String_AlreadyExisting()
        {
            Scope.Add("x", IntegerType.Create());
            
            var ast = Utils.BuildAST(@"let var x := ""abc"" in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is AlreadyDefinedError);
            
            Assert.That(Scope.DefinedVariables.Count == 1);
            Assert.That(Scope.ExistsDeclaration("x"));
            Assert.IsInstanceOf<IntegerType>(Scope.DefinedVariables["x"]);
        }

        [Test]
        public void Integer()
        {
            var ast = Utils.BuildAST(@"let var x := nil in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is NilAssignmentError);
        }

        [Test]
        public void Explicit_SameTypes()
        {
            Scope.Add(StringType.Create());
            Scope.Add(IntegerType.Create());
            var ast = Utils.BuildAST(@"let var x : string := ""abc"" in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(Scope.DefinedVariables.Count == 1);
            Assert.That(Scope.ExistsDeclaration("x"));
            Assert.IsInstanceOf<StringType>(Scope.DefinedVariables["x"]);
        }

        [Test]
        public void Explicit_DifferentTypes()
        {
            Scope.Add(StringType.Create());
            Scope.Add(IntegerType.Create());
            var ast = Utils.BuildAST(@"let var x : string := 1 in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is NotMatchingTypesError);
        }
    }
}
