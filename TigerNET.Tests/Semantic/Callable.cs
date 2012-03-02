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
    class Callable : SemanticTest 
    {
        [Test]
        public void Invalid_Argument_Type()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1(x : string) : int = 1
                                                    in
                                                        f1(1)
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is MessageError);
        }
        
        [Test]
        public void DistinctNumberOfArguments_More()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1(x : string) : int = 1
                                                    in
                                                        f1(1,2)
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is MessageError);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void DistinctNumberOfArguments_Less()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1(x : string, y : int) : int = 1
                                                    in
                                                        f1(1)
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is MessageError);
            Assert.That(ast.ReturnType is IntegerType);
        }
    
        [Test]
        public void Procedure_InsteadOfReturning()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1(x : string, y : int) = f1(""hello"", 0)
                                                    in
                                                        f1(""hello"", 0)
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }
    
    }
}
