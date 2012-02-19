using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser {
    internal class Break {
        [Test]
        public void Simple() {
            ExpressionNode ast = Utils.BuildAST("break");
            Assert.IsInstanceOf<BreakNode>(ast);
        }
    }
}