using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class CallableDeclaration {
        [Test]
        public void ProcedureWithoutParams() {
            ExpressionNode ast = Utils.BuildAST("let function f() = 1+2+3 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            IList<TypeField> fields = Utils.GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, null);
            Assert.AreEqual(fields.Count, 0);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void FunctionWithoutParams() {
            ExpressionNode ast = Utils.BuildAST("let function f() : int = 1+2+3 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            IList<TypeField> fields = Utils.GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, "int");
            Assert.AreEqual(fields.Count, 0);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void ProcedureWithParams() {
            ExpressionNode ast = Utils.BuildAST("let function f(x:string, y:int) = 1+2+3 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            IList<TypeField> fields = Utils.GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, null);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
            Assert.AreEqual(fields.Count, 2);
            Assert.AreEqual(fields[0].Id, "x");
            Assert.AreEqual(fields[0].TypeId, "string");
            Assert.AreEqual(fields[1].Id, "y");
            Assert.AreEqual(fields[1].TypeId, "int");
        }

        [Test]
        public void FunctionWithParams() {
            ExpressionNode ast = Utils.BuildAST("let function f(x:string, y:int) : int = 1+2+3 in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            string type = Utils.GetType(dec);
            ExpressionNode body = Utils.GetBody(dec);
            IList<TypeField> fields = Utils.GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, "int");
            Assert.IsInstanceOf<PlusOperatorNode>(body);
            Assert.AreEqual(fields.Count, 2);
            Assert.AreEqual(fields[0].Id, "x");
            Assert.AreEqual(fields[0].TypeId, "string");
            Assert.AreEqual(fields[1].Id, "y");
            Assert.AreEqual(fields[1].TypeId, "int");
        }
    }
}