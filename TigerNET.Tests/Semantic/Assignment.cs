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
        [Test]
        public void Assign_Procedure_NoValue()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    function f() = 1 /* No retorna valor */
    var x := 1
in
    x := f()
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(ast.ReturnType == null);
        }
        [Test]
        public void Redefine_Type_Nested_LetIn_IncorrectAssignment()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type a = array of int /* Definimos un primer array 'a' */
    type b = a
    var varB : b := nil
in 
    let 
        type a = array of int /* Redefinimos a */
    in
        /* Estamos asignando a una variable de tipo 'b' (que es del tipo 'a' que sobreescribimos) un valor del tipo 'a' nuevo
           y esto esta mal porque el tipo 'a' redefinido y el original son tipos distintos!
        */
        varB := a[10] of 10 
    end
end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }
        [Test]
        public void Assign_To_ReadOnly_Variable()
        {
            Scope.Add("readonly", IntegerType.Create(), true);
            var ast = Utils.BuildAST(@"readonly := 10");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }
    }
}
