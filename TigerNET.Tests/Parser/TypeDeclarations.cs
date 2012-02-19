using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class TypeDeclarations {
        [Test]
        public void AliasDeclaration() {
            ExpressionNode ast = Utils.BuildAST("let type a = b in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<AliasDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            Assert.AreEqual(name, "a");
            var aliasType = Utils.GetProperty<string>(dec, "AliasType");
            Assert.AreEqual(aliasType, "b");
        }

        [Test]
        public void RecordDeclaration_NoFields() {
            ExpressionNode ast = Utils.BuildAST("let type a = {} in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<RecordDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            Assert.AreEqual(name, "a");
            var fields = Utils.GetProperty<IList<TypeField>>(dec, "Fields");
            Assert.AreEqual(fields.Count, 0);
        }

        [Test]
        public void RecordDeclaration_2Fields() {
            ExpressionNode ast = Utils.BuildAST("let type a = {x : string, y : int} in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<RecordDeclarationNode>(dec);
            string name = Utils.GetName(dec);
            Assert.AreEqual(name, "a");
            var fields = Utils.GetProperty<IList<TypeField>>(dec, "Fields");
            Assert.AreEqual(fields.Count, 2);
            TypeField typeField1 = fields[0];
            Assert.AreEqual(typeField1.Id, "x");
            Assert.AreEqual(typeField1.TypeId, "string");
            TypeField typeField2 = fields[1];
            Assert.AreEqual(typeField2.Id, "y");
            Assert.AreEqual(typeField2.TypeId, "int");
        }

        [Test]
        public void ArrayDeclaration() {
            ExpressionNode ast = Utils.BuildAST("let type a = array of b in end");
            ExpressionNode dec = Utils.GetFirstDeclaration(ast);
            Assert.IsInstanceOf<ArrayDeclarationNode>(dec);
            Assert.AreEqual(((ArrayDeclarationNode) dec).Name, "a");
            Assert.AreEqual(((ArrayDeclarationNode) dec).TypeName, "b");
        }
    }
}