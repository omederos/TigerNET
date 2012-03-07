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
    public class CallableDeclaration : SemanticTest {
        [Test]
        public void Procedure_NoParameters_Int() {
            var ast = (LetInEndNode)Utils.BuildAST("let function f() = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.ExistsVariableOrCallable("f"));
            Assert.That(ast.Scope.DefinedCallables["f"].Fields.Count == 0);
            Assert.That(ast.Scope.DefinedCallables["f"].Name == "f");
            Assert.That(ast.Scope.DefinedCallables["f"].Type == null);
        }
        
        [Test]
        public void Procedure_OneStringParameter_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f(a:string) = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.ExistsVariableOrCallable("f"));
            Assert.That(ast.Scope.DefinedCallables["f"].Fields.Count == 1);
            Assert.That(ast.Scope.DefinedCallables["f"].Fields[0].Id == "a");
            Assert.That(ast.Scope.DefinedCallables["f"].Fields[0].TypeId == "string");
            Assert.That(ast.Scope.DefinedCallables["f"].Name == "f");
            Assert.That(ast.Scope.DefinedCallables["f"].Type == null);
        }

        [Test]
        public void Procedure_DuplicateParameters_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f(a:string, a:int) = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is DuplicateParameterError);
            Assert.That(!ast.Scope.ExistsVariableOrCallable("f"));
        }

        [Test]
        public void Procedure_UndefinedParameterType_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f(a:someType) = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(!ast.Scope.ExistsVariableOrCallable("f"));
        }

        [Test]
        public void Function_NoParameters_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f() : int = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.ExistsVariableOrCallable("f"));
            Assert.That(ast.Scope.DefinedCallables["f"].Fields.Count == 0);
            Assert.That(ast.Scope.DefinedCallables["f"].Name == "f");
            Assert.That(ast.Scope.DefinedCallables["f"].Type == "int");
        }

        [Test]
        public void Function_DifferentTypes_String_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f() : string = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
            Assert.That(!ast.Scope.ExistsVariableOrCallable("f"));
        }

        [Test]
        public void Function_UndefinedReturnType_Int()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f() : someType = 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(!ast.Scope.ExistsVariableOrCallable("f"));
        }

        [Test]
        public void Function_Return_Nil_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type record = {x : int} function f() : record = nil in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }
        [Test]
        public void Function_Return_Nil_NotAccepted()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f() : int = nil in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }

        [Test]
        public void Access_Function_Parameters_In_Definition()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let function f(x : int ) = x := 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }
    }
}
