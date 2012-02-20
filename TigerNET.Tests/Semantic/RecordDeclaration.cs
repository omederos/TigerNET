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
    public class RecordDeclaration : SemanticTest
    {
        [Test]
        public void NoParameters()
        {
            var ast = Utils.BuildAST("let type person = {} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsType("person"));
            Assert.That(Scope.DefinedTypes.ContainsKey("person"));
            Assert.That(Scope.DefinedTypes["person"] is RecordType);
        }

        [Test]
        public void OneParameter()
        {
            var ast = Utils.BuildAST("let type person = {Name : string} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsType("person"));
            Assert.That(Scope.DefinedTypes.ContainsKey("person"));
            Assert.That(Scope.DefinedTypes["person"] is RecordType);

            var type = (RecordType)Scope.DefinedTypes["person"];
            Assert.That(type.Fields.Count == 1);
            Assert.That(type.Fields["Name"] is StringType);
        }

        [Test]
        public void TwoParameters()
        {
            var ast = Utils.BuildAST("let type person = {Name : string, Age : int} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsType("person"));
            Assert.That(Scope.DefinedTypes.ContainsKey("person"));
            Assert.That(Scope.DefinedTypes["person"] is RecordType);

            var type = (RecordType)Scope.DefinedTypes["person"];
            Assert.That(type.Fields.Count == 2);
            Assert.That(type.Fields["Name"] is StringType);
            Assert.That(type.Fields["Age"] is IntegerType);
        }

        [Test]
        public void DuplicateFields()
        {
            var ast = Utils.BuildAST("let type person = {Name : string, Name : int} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is DuplicateFieldError);
            Assert.That(dec.ReturnType == null);
        }

        [Test]
        public void UndefinedFieldType()
        {
            var ast = Utils.BuildAST("let type person = {Name : string, Age : someType} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(dec.ReturnType == null);
        }

        [Test]
        public void AlreadyExistingType()
        {
            var ast = Utils.BuildAST("let type string = {Name : string, Age : int} in end");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is AlreadyDefinedError);
            Assert.That(dec.ReturnType == null);
        }
    }
}
