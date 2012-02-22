using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Semantic
{
    class GroupDeclarations
    {
        [Test]
         public void OneVar_OneFunc_OneType() {
             var v = GetVarDeclaration();
             var c = GetCallableDeclaration();
             var r = GetRecordDeclaration();
             var declarations = new List<DeclarationNode>
                                    {v, c, r};
             var grouped = declarations.GroupDeclarations();
             Assert.That(grouped.Count == 3);
             Assert.That(grouped[0][0] == v);
             Assert.That(grouped[1][0] == c);
             Assert.That(grouped[2][0] == r);
         }

        [Test]
        public void TwoTypes()
        {
            var r = GetRecordDeclaration();
            var a = GetArrayDeclaration();
            var declarations = new List<DeclarationNode> { r, a };
            var grouped = declarations.GroupDeclarations();
            Assert.That(grouped.Count == 1);
            Assert.That(grouped[0][0] == r);
            Assert.That(grouped[0][1] == a);
        }
        
        [Test]
        public void Var_Func_Type_Var_Func_Type()
        {
            var v = GetVarDeclaration();
            var c = GetCallableDeclaration();
            var r = GetRecordDeclaration();
            var declarations = new List<DeclarationNode> { v, c, r, v, c, r };
            var grouped = declarations.GroupDeclarations();
            Assert.That(grouped.Count == 6);
            Assert.That(grouped[0][0] == v);
            Assert.That(grouped[1][0] == c);
            Assert.That(grouped[2][0] == r);
            Assert.That(grouped[3][0] == v);
            Assert.That(grouped[4][0] == c);
            Assert.That(grouped[5][0] == r);
        }

        [Test]
        public void TwoVar_TwoFunc_TwoTypes()
        {
            var v = GetVarDeclaration();
            var c = GetCallableDeclaration();
            var r = GetRecordDeclaration();
            var a = GetArrayDeclaration();
            var al = GetAliasDeclaration();
            var declarations = new List<DeclarationNode> { v, v, c, c, r, a, al };
            var grouped = declarations.GroupDeclarations();
            Assert.That(grouped.Count == 3);
            Assert.That(grouped[0][0] == v);
            Assert.That(grouped[0][1] == v);
            Assert.That(grouped[1][0] == c);
            Assert.That(grouped[1][1] == c);
            Assert.That(grouped[2][0] == r);
            Assert.That(grouped[2][1] == a);
            Assert.That(grouped[2][2] == al);
        }

        [Test]
        public void ThreeTypes_OneVar()
        {
            var v = GetVarDeclaration();
            var c = GetCallableDeclaration();
            var r = GetRecordDeclaration();
            var a = GetArrayDeclaration();
            var al = GetAliasDeclaration();
            var declarations = new List<DeclarationNode> { r, a, al, v };
            var grouped = declarations.GroupDeclarations();
            Assert.That(grouped.Count == 2);
            Assert.That(grouped[0][0] == r);
            Assert.That(grouped[0][1] == a);
            Assert.That(grouped[0][2] == al);
            Assert.That(grouped[1][0] == v);
        }

        private VariableDeclarationNode GetVarDeclaration() {
            return new VariableDeclarationNode("x", new IntegerLiteralNode(0));
        }
        
        private CallableDeclarationNode GetCallableDeclaration() {
            return new CallableDeclarationNode("f", new List<TypeField>(), new IntegerLiteralNode(1));
        }
        
        private RecordDeclarationNode GetRecordDeclaration()
        {
            return new RecordDeclarationNode("x", new List<TypeField>());
        }

        private ArrayDeclarationNode GetArrayDeclaration()
        {
            return new ArrayDeclarationNode("x", "string");
        }

        private AliasDeclarationNode GetAliasDeclaration()
        {
            return new AliasDeclarationNode("x", "string");
        }
    }


}
