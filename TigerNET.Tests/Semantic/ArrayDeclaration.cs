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
    public class ArrayDeclaration : SemanticTest
    {
        [Test]
        public void ArrayCorrect()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type list = array of string in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.CurrentScope.ExistsType("list"));
            Assert.That(ast.CurrentScope.GetType("list") is ArrayType);
            var type = (ArrayType)ast.CurrentScope.GetType("list");
            Assert.That(type.ElementsType is StringType);
        }

//        [Test]
//        public void AlreadyExistingType()
//        {
//            var ast = var ast = (LetInEndNode)Utils.BuildAST("let type string = array of string in end");
//            var dec = Utils.GetFirstDeclaration(ast);
//            dec.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 1);
//            Assert.That(Errors[0] is AlreadyDefinedError);
//            Assert.That(dec.ReturnType == null);
//        }

        [Test]
        public void AlreadyExistingType_ButInOuterScope()
        {
            var s = new Scope();
            s.Add(new RecordType("someRecord", new Fields()));
            Scope.Parent = s;
            
            var ast = (LetInEndNode)Utils.BuildAST("let type someRecord = array of string in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.CurrentScope.ExistsType("someRecord"));
            Assert.That(ast.CurrentScope.GetType("someRecord") is ArrayType);
            var type = (ArrayType)ast.CurrentScope.GetType("someRecord");
            Assert.That(type.ElementsType is StringType);
        }

        [Test]
        public void UndefinedTypeOfArray()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type list = array of someType in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
        }
    }
}
