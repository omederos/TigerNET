﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class AliasDeclaration : SemanticTest
    {
        [Test]
        public void StringAlias() {
            var ast = (LetInEndNode)Utils.BuildAST("let type a = string in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.ExistsType("a"));
            Assert.That(ast.Scope.GetType("a") is StringType);
        }

        [Test]
        public void UndefinedTypeAlias()
        {
            var ast = Utils.BuildAST("let type a = x in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
        }

//        [Test]
//        public void AlreadyExistingType()
//        {
//            var ast = Utils.BuildAST("let type string = int in end");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 1);
//            Assert.That(Errors[0] is AlreadyDefinedError);
//        }
    }
}
