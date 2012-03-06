using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    class StringLiteral : CodeGenTest
    {
        [Test]
        public void String() {
            var result = GenerateCode(@"""hello world""");
            Assert.That(result == "hello world");
        }
    }
}
