using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    public class MinusUnary : CodeGenTest
    {
        [Test]
        public void Minus10() {
            var result = GenerateCode("-10");
            Assert.That(result == "-10");
        }
        [Test]
        public void MinusMinus10() {
            var result = GenerateCode("--10");
            Assert.That(result == "10");
        }
    }
}
