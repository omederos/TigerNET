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
        IEnumerable<ExpressionNode> GetASTs(string expression)
        {
            foreach (var op in _compOperators)
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

        //TODO: Comprobar con instancias de arrays/records (dos arrays idems, dos records idems, dos records diferentes, un array y un record, etc)

//        [Test]
//        public void Eq_TwoSameRecords()
//        {
//            Scope.Add(new RecordType("x", new Fields(new Dictionary<string, TigerType>{{"a", StringType.Create()}})));
//            var asts = GetASTs(@"""Oscar""{0}""Oscar""");
//            foreach (var ast in asts) {
//                ast.CheckSemantic(Scope, Errors);
//                ((BinaryOperatorNode)ast).Left.ReturnType = Scope.GetType("x");
//                ((BinaryOperatorNode)ast).Right.ReturnType = Scope.GetType("x");
//                Assert.That(Errors.Count == 0);
//                Assert.That(ast.ReturnType is IntegerType);
//                Errors.Clear();
//            }
//        }
//
//        [Test]
//        public void Eq_TwoSameArrays() {
//            Scope.Add(new ArrayType("x", StringType.Create()));
//            var asts = GetASTs(@"""Oscar""{0}""Oscar""");
//            foreach (var ast in asts)
//            {
//                ast.CheckSemantic(Scope, Errors);
//                ((BinaryOperatorNode)ast).Left.ReturnType = Scope.GetType("x");
//                ((BinaryOperatorNode)ast).Right.ReturnType = Scope.GetType("x");
//                Assert.That(Errors.Count == 0);
//                Assert.That(ast.ReturnType is IntegerType);
//                Errors.Clear();
//            }
//        }
//
//        [Test]
//        public void Eq_Record_Array()
//        {
//            Scope.Add(new ArrayType("x", StringType.Create()));
//            Scope.Add(new RecordType("y", new Fields(new Dictionary<string, TigerType> { { "a", StringType.Create() } })));
//            var asts = GetASTs(@"""Oscar""{0}""Oscar""");
//            foreach (var ast in asts)
//            {
//                ast.CheckSemantic(Scope, Errors);
//                ((BinaryOperatorNode)ast).Left.ReturnType = Scope.GetType("x");
//                ((BinaryOperatorNode)ast).Right.ReturnType = Scope.GetType("y");
//                Assert.That(Errors.Count == 1);
//                Assert.That(Errors[0] is OperatorError);
//                Errors.Clear();
//            }
//        }
    }
}
