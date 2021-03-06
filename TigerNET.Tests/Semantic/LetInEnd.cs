﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    class LetInEnd : SemanticTest
    {   
        [Test]        
        public void Recursive_TwoRecords_OneArray_OK() {
            var ast = Utils.BuildAST("let type a = {x : b} type b = { y : a } type c = array of a in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void Recursive_TwoRecords_OneArray_OneVar_OK()
        {
            var ast = Utils.BuildAST("let type a = {x : b} type b = { y : a } type c = array of a var x := 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void Three_Alias_Cycle()
        {
            var ast = Utils.BuildAST("let type a = b type b = c type c = a in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is CyclicAliasesError);
        }

        [Test]
        public void One_Alias_Cycle()
        {
            var ast = Utils.BuildAST("let type a = a in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is CyclicAliasesError);
        }

        [Test]
        public void Two_Groups_Of_Cyclic_Aliases()
        {
            var ast = Utils.BuildAST("let type a = b type b = a type h = i type i = h in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is CyclicAliasesError);
        }

        [Test]
        public void Various_Aliases_No_Cycle()
        {
            var ast = Utils.BuildAST("let type a = b type b = c type c = string in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void Various_Aliases_No_Cycle_2()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type r = { x : a } type a = b type c = r type b = c in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedTypes["r"] is RecordType);
            Assert.That(((RecordType)ast.Scope.DefinedTypes["r"]).Fields["x"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["b"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["c"] is RecordType);
        }

        [Test]
        public void TwoBlocks_Various_Aliases_No_Cycle()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type r = { x : a } type a = b type c = r type b = c var x := 1 type h = i type i = j type j = int in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.Scope.DefinedTypes["r"] is RecordType);
            Assert.That(((RecordType)ast.Scope.DefinedTypes["r"]).Fields["x"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["b"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["c"] is RecordType);
            Assert.That(ast.Scope.DefinedVariables["x"].Type is IntegerType);
            Assert.That(ast.Scope.DefinedTypes["h"] is IntegerType);
            Assert.That(ast.Scope.DefinedTypes["i"] is IntegerType);
            Assert.That(ast.Scope.DefinedTypes["j"] is IntegerType);
        }

        [Test]
        public void TwoBlocks_Various_Aliases_No_Cycle_2()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type b = r type r = { x : a } type a = { y : b } var x := 1 type h = i type i = j type j = int in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            
            //Que los 3 sean RecordType
            Assert.That(ast.Scope.DefinedTypes["r"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.Scope.DefinedTypes["b"] is RecordType);

            //B y R son exactamente los mismos
            Assert.That(ast.Scope.DefinedTypes["r"] == ast.Scope.DefinedTypes["b"]);
            
            //El tipo del campo 'x' de 'r' es igual a 'a'
            Assert.That(((RecordType)ast.Scope.DefinedTypes["r"]).Fields["x"] == ast.Scope.DefinedTypes["a"]);

            //El tipo del campo 'y' de 'a' es igual a 'b'
            Assert.That(((RecordType)ast.Scope.DefinedTypes["a"]).Fields["y"] == ast.Scope.DefinedTypes["b"]);
        }

        [Test]
        public void Recursive_Array_Alias()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type a = b
                                                        type b = c
                                                        type c = array of a
                                                    in
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);

            //Que los 3 sean RecordType
            Assert.That(ast.Scope.DefinedTypes["a"] is ArrayType);
            Assert.That(ast.Scope.DefinedTypes["b"] is ArrayType);
            Assert.That(ast.Scope.DefinedTypes["c"] is ArrayType);

            Assert.That(ast.Scope.DefinedTypes["a"] == ast.Scope.DefinedTypes["b"]);
            Assert.That(ast.Scope.DefinedTypes["b"] == ast.Scope.DefinedTypes["c"]);
            var arr = (ArrayType) ast.Scope.DefinedTypes["c"];
            Assert.That(arr.ElementsType is ArrayType);
            Assert.That(arr.ElementsType == ast.Scope.DefinedTypes["a"]);
        }
        
        [Test]
        public void TwoFunctions_SameName()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f() : int = 0
                                                        function f() : int = 1
                                                    in
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is AlreadyDefinedError);
        }

        [Test]
        public void OneFunction_Recursive()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f() : int = f()
                                                    in
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void TwoFunctions_MutuallyRecursive()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1() : int = f2()
                                                        function f2() : int = f1()
                                                    in
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void TwoFunctions_MutuallyRecursive_WithExprSeq()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1() : int = f2()
                                                        function f2() : int = f1()
                                                    in
                                                        f1()
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void TwoFunctions_MutuallyRecursive_WithExprSeq1()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1() : int = f2()
                                                        function f2() : int = f1()
                                                    in
                                                        f1() ;
                                                        f2()
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }
        
        [Test]
        public void CallUndefinedFunction_InDefinition()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1() : int = f2()
                                                        function f2() : int = f3()
                                                    in
                                                        f1() ;
                                                        f2()
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedFunctionError);
        }

        [Test]
        public void UseUndefinedFunction_InExprSeq()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        function f1() : int = f2()
                                                        function f2() : int = f1()
                                                    in
                                                        f3()
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedFunctionError);
        }

        #region Expresion Sequence Tests
        [Test]
        public void No_Expressions()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        var x := 2
                                                        var y := 3
                                                    in
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(!ast.ReturnsValue());
        }

        [Test]
        public void Integer()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        var x := 2
                                                        var y := 3
                                                    in
                                                        2
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void Integer_String()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        var x := 2
                                                        var y := 3
                                                    in
                                                        2;
                                                        ""Pepe""
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is StringType);
        }
        #endregion
    }
}
