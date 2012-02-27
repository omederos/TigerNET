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
    class ArrayLiteral : SemanticTest
    {
        [Test]
        public void Array_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = array of int
                                                    in
                                                        p[10] of 0
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is ArrayType);
        }
        [Test]
        public void Wrong_Index_Type()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = array of int
                                                    in
                                                        p[""str""] of 0
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }

        [Test]
        public void Wrong_InitialValue_Type()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = array of int
                                                    in
                                                        p[0] of ""initial value""
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }
    
        [Test]
        public void IndexIsResultOfFunction()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = array of int
                                                        function p(x : int) : int = p(10)
                                                    in
                                                        p[p(2)] of p(20)
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }
    }
}
