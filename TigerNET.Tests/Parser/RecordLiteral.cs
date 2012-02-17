using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class RecordLiteral
    {
        public IList<FieldAssignmentNode> GetFields(ExpressionNode expr)
        {
            return Utils.GetProperty<IList<FieldAssignmentNode>>(expr, "Fields");
        }

        [Test]
        public void NoFields()
        {
            var ast = Utils.BuildAST("someType {}");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            var fields = GetFields(ast);
            Assert.AreEqual(fields.Count, 0);
        }

        [Test]
        public void OneField()
        {
            var ast = Utils.BuildAST("someType {a = 1 }");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            var fields = GetFields(ast);
            Assert.AreEqual(fields.Count, 1);
            var field1 = fields[0];
            Assert.AreEqual(field1.FieldName, "a");
            Assert.IsInstanceOf<IntegerLiteralNode>(field1.Body);
        }

        [Test]
        public void TwoFields()
        {
            var ast = Utils.BuildAST(@"someType {a = 1, b = ""abc""}");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            var fields = GetFields(ast);
            Assert.AreEqual(fields.Count, 2);
            var field1 = fields[0];
            Assert.AreEqual(field1.FieldName, "a");
            Assert.IsInstanceOf<IntegerLiteralNode>(field1.Body);
            var field2 = fields[1];
            Assert.AreEqual(field2.FieldName, "b");
            Assert.IsInstanceOf<StringLiteralNode>(field2.Body);
        }
    }
}
