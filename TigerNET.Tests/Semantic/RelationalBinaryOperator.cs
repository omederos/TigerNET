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
    public class RelationalBinaryOperator : SemanticTest
    {
        private string[] _compOperators = {  ">", ">=", "<", "<="};
        IEnumerable<ExpressionNode> GetASTs(string expression, string[] operators = null)
        {
            foreach (var op in operators ?? _compOperators)
            {
                yield return Utils.BuildAST(string.Format(expression, op));
            }
        }

        [Test]
        public void Comp_Int_Int()
        {
            var asts = GetASTs("1{0}2");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_NoReturn_Int()
        {
            var asts = GetASTs("(){0}2");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 1);
                Assert.That(Errors[0] is NonValueReturnError);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_String_Int()
        {
            var asts = GetASTs(@"""Oscar""{0}2");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 1);
                Assert.That(Errors[0] is OperatorError);
                Errors.Clear();
            }
        }
        [Test]
        public void Comp_String_String()
        {
            var asts = GetASTs(@"""Oscar""{0}""Oscar""");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_Nil_Record()
        {
            var asts = GetASTs("let type x = {{x : int}} var i := x{{ x = 0 }} in nil{0}i", new[] {"=", "<>"});
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_Record_Nil()
        {
            var asts = GetASTs("let type x = {{x : int}} var i := x{{ x = 0 }} in i{0}nil", new[] {"=", "<>"});
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }
        [Test]
        public void Comp_Nil_Array()
        {
            var asts = GetASTs("let type x = array of int var i := x[10] of 0 in i{0}nil", new[] {"=", "<>"});
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_Array_Nil()
        {
            var asts = GetASTs("let type x = array of int var i := x[10] of 0 in i{0}nil", new[] {"=", "<>"});
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }
        [Test]
        public void Comp_String_Nil()
        {
            var asts = GetASTs(@"""hello""{0}nil");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }
        [Test]
        public void Comp_Nil_String()
        {
            var asts = GetASTs(@"nil{0}""hello""");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }

        [Test]
        public void Comp_Nil_Int()
        {
            var asts = GetASTs(@"nil{0}0");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 1);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }
    }
}
