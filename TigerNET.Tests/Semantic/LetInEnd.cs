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
            Assert.That(ast.CurrentScope.DefinedTypes["r"] is RecordType);
            Assert.That(((RecordType)ast.CurrentScope.DefinedTypes["r"]).Fields["x"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["b"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["c"] is RecordType);
        }

        [Test]
        public void TwoBlocks_Various_Aliases_No_Cycle()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type r = { x : a } type a = b type c = r type b = c var x := 1 type h = i type i = j type j = int in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.CurrentScope.DefinedTypes["r"] is RecordType);
            Assert.That(((RecordType)ast.CurrentScope.DefinedTypes["r"]).Fields["x"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["b"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["c"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedVariables["x"] is IntegerType);
            Assert.That(ast.CurrentScope.DefinedTypes["h"] is IntegerType);
            Assert.That(ast.CurrentScope.DefinedTypes["i"] is IntegerType);
            Assert.That(ast.CurrentScope.DefinedTypes["j"] is IntegerType);
        }

        [Test]
        public void TwoBlocks_Various_Aliases_No_Cycle_2()
        {
            var ast = (LetInEndNode)Utils.BuildAST("let type b = r type r = { x : a } type a = { y : b } var x := 1 type h = i type i = j type j = int in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            
            //Que los 3 sean RecordType
            Assert.That(ast.CurrentScope.DefinedTypes["r"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["a"] is RecordType);
            Assert.That(ast.CurrentScope.DefinedTypes["b"] is RecordType);

            //B y R son exactamente los mismos
            Assert.That(ast.CurrentScope.DefinedTypes["r"] == ast.CurrentScope.DefinedTypes["b"]);
            
            //El tipo del campo 'x' de 'r' es igual a 'a'
            Assert.That(((RecordType)ast.CurrentScope.DefinedTypes["r"]).Fields["x"] == ast.CurrentScope.DefinedTypes["a"]);

            //El tipo del campo 'y' de 'a' es igual a 'b'
            Assert.That(((RecordType)ast.CurrentScope.DefinedTypes["a"]).Fields["y"] == ast.CurrentScope.DefinedTypes["b"]);
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
            Assert.That(ast.CurrentScope.DefinedTypes["a"] is ArrayType);
            Assert.That(ast.CurrentScope.DefinedTypes["b"] is ArrayType);
            Assert.That(ast.CurrentScope.DefinedTypes["c"] is ArrayType);

            Assert.That(ast.CurrentScope.DefinedTypes["a"] == ast.CurrentScope.DefinedTypes["b"]);
            Assert.That(ast.CurrentScope.DefinedTypes["b"] == ast.CurrentScope.DefinedTypes["c"]);
            var arr = (ArrayType) ast.CurrentScope.DefinedTypes["c"];
            Assert.That(arr.ElementsType is ArrayType);
            Assert.That(arr.ElementsType == ast.CurrentScope.DefinedTypes["a"]);
        }
    }
}
