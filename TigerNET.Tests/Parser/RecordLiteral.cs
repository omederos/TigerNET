using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class RecordLiteral {
        [Test]
        public void NoFields() {
            ExpressionNode ast = Utils.BuildAST("someType {}");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            IList<FieldAssignmentNode> fields = Utils.GetFieldAssignments(ast);
            Assert.AreEqual(fields.Count, 0);
        }

        [Test]
        public void OneField() {
            ExpressionNode ast = Utils.BuildAST("someType {a = 1 }");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            IList<FieldAssignmentNode> fields = Utils.GetFieldAssignments(ast);
            Assert.AreEqual(fields.Count, 1);
            FieldAssignmentNode field1 = fields[0];
            Assert.AreEqual(field1.FieldName, "a");
            Assert.IsInstanceOf<IntegerLiteralNode>(field1.Body);
            Assert.That(field1.Parent == ast);
            Assert.That(field1.Body.Parent == field1);
        }

        [Test]
        public void TwoFields() {
            ExpressionNode ast = Utils.BuildAST(@"someType {a = 1, b = ""abc""}");
            Assert.IsInstanceOf<RecordLiteralNode>(ast);
            IList<FieldAssignmentNode> fields = Utils.GetFieldAssignments(ast);
            Assert.AreEqual(fields.Count, 2);
            FieldAssignmentNode field1 = fields[0];
            Assert.AreEqual(field1.FieldName, "a");
            Assert.IsInstanceOf<IntegerLiteralNode>(field1.Body);
            Assert.That(field1.Parent == ast);
            Assert.That(field1.Body.Parent == field1);
            FieldAssignmentNode field2 = fields[1];
            Assert.AreEqual(field2.FieldName, "b");
            Assert.IsInstanceOf<StringLiteralNode>(field2.Body);
            Assert.That(field2.Parent == ast);
            Assert.That(field2.Body.Parent == field2);
        }
    }
}