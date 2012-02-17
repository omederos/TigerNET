using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;

namespace TigerNET.Tests.Parser
{
    class Break
    {
        [Test]
        public void Plus()
        {
            var ast = Utils.BuildAST("break");
            Assert.IsInstanceOf<BreakNode>(ast);
        }
    }
}
