using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class NilLiteral {
        [Test]
        public void Nil() {
            ExpressionNode ast = Utils.BuildAST("nil");
            Assert.IsInstanceOf<NilLiteralNode>(ast);
        }
    }
}