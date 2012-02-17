using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class TypeDeclarations
    {
        private ExpressionNode GetFirstDeclaration(ExpressionNode expr) {
            return ((LetInEndNode) expr).Declarations[0];
        }

        private string GetName(ExpressionNode expr) {
            return Utils.GetProperty<string>(expr, "Name");
        }

        [Test]
        public void AliasDeclaration() {
            var ast = Utils.BuildAST("let type a = b in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<AliasDeclarationNode>(dec);
            var name = GetName(dec);
            Assert.AreEqual(name, "a");
            var aliasType = Utils.GetProperty<string>(dec, "AliasType");
            Assert.AreEqual(aliasType, "b");
        }

        [Test]
        public void RecordDeclaration_NoFields()
        {
            var ast = Utils.BuildAST("let type a = {} in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<RecordDeclarationNode>(dec);
            var name = GetName(dec);
            Assert.AreEqual(name, "a");
            var fields = Utils.GetProperty<IList<TypeField>>(dec, "Fields");
            Assert.AreEqual(fields.Count, 0);
        }
        
        [Test]
        public void RecordDeclaration_2Fields()
        {
            var ast = Utils.BuildAST("let type a = {x : string, y : int} in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<RecordDeclarationNode>(dec);
            var name = GetName(dec);
            Assert.AreEqual(name, "a");
            var fields = Utils.GetProperty<IList<TypeField>>(dec, "Fields");
            Assert.AreEqual(fields.Count, 2);
            var typeField1 = fields[0];
            Assert.AreEqual(typeField1.Id, "x");
            Assert.AreEqual(typeField1.TypeId, "string");
            var typeField2 = fields[1];
            Assert.AreEqual(typeField2.Id, "y");
            Assert.AreEqual(typeField2.TypeId, "int");
        }

        [Test]
        public void ArrayDeclaration() {
            var ast = Utils.BuildAST("let type a = array of b in end");
            var dec = GetFirstDeclaration(ast);
            Assert.IsInstanceOf<ArrayDeclarationNode>(dec);
            Assert.AreEqual(((ArrayDeclarationNode) dec).Name, "a");
            Assert.AreEqual(((ArrayDeclarationNode) dec).TypeName, "b");
        }
    }
}
