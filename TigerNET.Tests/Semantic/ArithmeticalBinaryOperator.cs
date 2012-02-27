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
    public class ArithmeticalBinaryOperator : SemanticTest {
        private string[] operators = {"+", "-", "*", "-"};
        IEnumerable<ExpressionNode> GetASTs(string expression) {
            foreach (var op in operators) {
                yield return Utils.BuildAST(string.Format(expression, op));
            }
        }
            
        [Test]
        public void Int_Int() {
            var asts = GetASTs("1{0}2");
            foreach (var ast in asts) {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 0);
                Assert.That(ast.ReturnType is IntegerType);
                Errors.Clear();
            }
        }
        
        [Test]
        public void NoReturn_Int() {
            var asts = GetASTs("(){0}2");
            foreach (var ast in asts) {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 1);
                Assert.That(Errors[0] is NonValueReturnError);
                Errors.Clear();
            }
        }

        [Test]
        public void String_Int()
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
        public void String_String()
        {
            var asts = GetASTs(@"""Oscar""{0}""Oscar""");
            foreach (var ast in asts)
            {
                ast.CheckSemantic(Scope, Errors);
                Assert.That(Errors.Count == 1);
                Assert.That(Errors[0] is OperatorError);
                Errors.Clear();
            }
        }
    }
}
