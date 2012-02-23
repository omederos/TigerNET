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
            var ast = (LetInEndNode)Utils.BuildAST("let type person = {} in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.CurrentScope.ExistsType("person"));
            Assert.That(ast.CurrentScope.DefinedTypes.ContainsKey("person"));
            Assert.That(ast.CurrentScope.DefinedTypes["person"] is RecordType);
        }

        [Test]
        public void OneParameter()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type person = {Name : string} in end");
            
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            
            Assert.That(ast.CurrentScope.ExistsType("person"));
            Assert.That(ast.CurrentScope.DefinedTypes.ContainsKey("person"));
            Assert.That(ast.CurrentScope.DefinedTypes["person"] is RecordType);

            var type = (RecordType)ast.CurrentScope.DefinedTypes["person"];
            Assert.That(type.Fields.Count == 1);
            Assert.That(type.Fields["Name"] is StringType);
        }

        [Test]
        public void TwoParameters()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type person = {Name : string, Age : int} in end");
            
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            
            Assert.That(ast.CurrentScope.ExistsType("person"));
            Assert.That(ast.CurrentScope.DefinedTypes.ContainsKey("person"));
            Assert.That(ast.CurrentScope.DefinedTypes["person"] is RecordType);

            var type = (RecordType)ast.CurrentScope.DefinedTypes["person"];
            Assert.That(type.Fields.Count == 2);
            Assert.That(type.Fields["Name"] is StringType);
            Assert.That(type.Fields["Age"] is IntegerType);
        }

        [Test]
        public void DuplicateFields()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type person = {Name : string, Name : int} in end");
            
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is DuplicateFieldError);
            
        }

        [Test]
        public void UndefinedFieldType()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type person = {Name : string, Age : someType} in end");
            
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            
        }

//        [Test]
//        public void AlreadyExistingType()
//        {
//            var ast = (LetInEndNode)Utils.BuildAST("let type string = {Name : string, Age : int} in end");
//            
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 1);
//            Assert.That(Errors[0] is AlreadyDefinedError);
//            
//        }
    }
}
