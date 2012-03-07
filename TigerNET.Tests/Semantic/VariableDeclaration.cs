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
    public class SemanticTest {
        protected Scope Scope;
        protected IList<Error> Errors;

        [SetUp]
        public void Init()
        {
            Scope = new Scope();
            Scope.Add(IntegerType.Create());
            Scope.Add(StringType.Create());
            Errors = new List<Error>();
        }
    }

    public class VariableDeclaration : SemanticTest
    {
        [Test]
        public void String() {
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x := ""abc"" in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<StringType>(ast.Scope.DefinedVariables["x"].Type);
        }

        [Test]
        public void String_AlreadyExisting_OK()
        {
            Scope.Add("x", StringType.Create());
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x := ""abc"" in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<StringType>(ast.Scope.DefinedVariables["x"].Type);
        }

        [Test]
        public void Integer()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x := nil in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is NilAssignmentError);
        }

        [Test]
        public void Explicit_SameTypes()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x : string := ""abc"" in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<StringType>(ast.Scope.DefinedVariables["x"].Type);
        }

        [Test]
        public void Explicit_DifferentTypes()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x : string := 1 in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }

        [Test]
        public void Explicit_Record_AssignNil()
        {
            //Definimos un record en el scope
            Scope.Add(new RecordType("rec", new Fields()));
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x : rec := nil in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<RecordType>(ast.Scope.DefinedVariables["x"].Type);
        }

        [Test]
        public void Explicit_Array_AssignNil()
        {
            //Definimos un array recen el scope
            Scope.Add(new ArrayType("arr", StringType.Create()));
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x : arr := nil in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<ArrayType>(ast.Scope.DefinedVariables["x"].Type);
        }

        [Test]
        public void Explicit_String_AssignNil()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let var x : string := nil in end");
            
            ast.CheckSemantic(Scope, Errors);

            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedVariables.Count == 1);
            Assert.That(ast.Scope.ExistsVariableOrCallable("x"));
            Assert.IsInstanceOf<StringType>(ast.Scope.DefinedVariables["x"].Type);
        }
    }
}
