using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    class ArithmeticalBinaryOperator : CodeGenTest
    {
        [Test]
        public void Plus() {
            var result = GenerateCode("1+2");
            Assert.That(result == "3");
        }
        [Test]
        public void Minus() {
            var result = GenerateCode("1-2");
            Assert.That(result == "-1");
        }
        [Test]
        public void Prod() {
            var result = GenerateCode("2*2");
            Assert.That(result == "4");
        }
        [Test]
        public void Div() {
            var result = GenerateCode("4/2");
            Assert.That(result == "2");
        }
    }
}
