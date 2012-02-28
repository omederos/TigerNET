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
    public class ArrayAccess : SemanticTest
    {
        [Test]
        public void Array_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r = array of int
    var y := r[10] of 0
in
    y[0]
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void NestedArrays()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = array of r2
    type r2 = array of int
    var y2 := r2[10] of 0
    var x1 := r1[10] of y2
in
   x1[10][20]
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void Accessing_No_Array()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r = { name : string }
    var y := r{name = ""Oscar""}
in
    y[0]
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }
    }
}
