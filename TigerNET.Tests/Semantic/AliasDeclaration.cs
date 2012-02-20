using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class AliasDeclaration : SemanticTest
    {
        [Test]
        public void StringAlias() {
            var ast = Utils.BuildAST("let type a = string in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsType("a"));
            Assert.That(Scope.DefinedTypes["a"] is StringType);
        }

        [Test]
        public void UndefinedTypeAlias()
        {
            var ast = Utils.BuildAST("let type a = x in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(dec.ReturnType == null);
        }

        [Test]
        public void AlreadyExistingType()
        {
            var ast = Utils.BuildAST("let type string = int in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is AlreadyDefinedError);
            Assert.That(dec.ReturnType == null);
        }
    }
}
