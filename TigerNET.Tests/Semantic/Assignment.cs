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
    public class Assignment : SemanticTest
    {
        [Test]
        public void Alias_String_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type a = string 
    var x : a := ""Hello""
in 
    x := ""Oscar""
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }

        [Test]
        public void Assign_To_Diferente_Record()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = {x : string } 
    type r2 = {x : string } 
    var x : r1 := r1{x = ""Hello""}
in 
    x := r2{x = ""Hello""}
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(ast.ReturnType == null);
        }


        [Test]
        public void Assign_Nil_To_Record()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = {x : string } 
    var x := r1{x = """"}
in 
    x := nil
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Assign_Nil_To_String()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let  
    var x := ""string""
in 
    x := nil
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Assign_Nil_To_Array()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = array of int
    var x := r1[0] of 0
in 
    x := nil
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Assign_To_Array_Position()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = array of int
    var x := r1[0] of 0
in 
    x[0] := 10
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Assign_To_Array_Position_Nil()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = array of string
    var x := r1[0] of ""Empty""
in 
    x[0] := nil
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Assign_To_Record_Field()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r1 = {x : string }
    var x := r1{x = ""Empty""}
in 
    x.x := nil
    x.x := nil
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType == null);
        }
    }
}
