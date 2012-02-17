using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class NilLiteral
    {
        [Test]
        public void Nil()
        {
            var ast = Utils.BuildAST("nil");
            Assert.IsInstanceOf<NilLiteralNode>(ast);
        }
    }
}
