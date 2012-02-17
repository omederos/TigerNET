using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class CallableDeclaration
    {
        private ExpressionNode GetFirstDeclaration(ExpressionNode expr)
        {
            return ((LetInEndNode)expr).Declarations[0];
        }

        private string GetName(ExpressionNode expr)
        {
            return Utils.GetProperty<string>(expr, "Name");
        }

        private string GetType(ExpressionNode expr)
        {
            return Utils.GetProperty<string>(expr, "Type");
        }

        private ExpressionNode GetBody(ExpressionNode expr)
        {
            return Utils.GetProperty<ExpressionNode>(expr, "Body");
        }
        
        private IList<TypeField> GetFields(ExpressionNode expr)
        {
            return Utils.GetProperty<IList<TypeField>>(expr, "Fields");
        }



        [Test]
        public void ProcedureWithoutParams()
        {
            var ast = Utils.BuildAST("let function f() = 1+2+3 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            var name = GetName(dec);
            var type  = GetType(dec);
            var body = GetBody(dec);
            var fields = GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, null);
            Assert.AreEqual(fields.Count, 0);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void FunctionWithoutParams()
        {
            var ast = Utils.BuildAST("let function f() : int = 1+2+3 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            var name = GetName(dec);
            var type = GetType(dec);
            var body = GetBody(dec);
            var fields = GetFields(dec);
            Assert.AreEqual(name, "f");
            Assert.AreEqual(type, "int");
            Assert.AreEqual(fields.Count, 0);
            Assert.IsInstanceOf<PlusOperatorNode>(body);
        }

        [Test]
        public void ProcedureWithParams()
        {
            var ast = Utils.BuildAST("let function f(x:string, y:int) = 1+2+3 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            var name = GetName(dec);
            var type = GetType(dec);
            var body = GetBody(dec);
            var fields = GetFields(dec);
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
        public void FunctionWithParams()
        {
            var ast = Utils.BuildAST("let function f(x:string, y:int) : int = 1+2+3 in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<CallableDeclarationNode>(dec);
            var name = GetName(dec);
            var type = GetType(dec);
            var body = GetBody(dec);
            var fields = GetFields(dec);
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
