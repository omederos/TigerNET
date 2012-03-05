using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    public class LogicalOperatorNode : CodeGenTest
    {
        [Test]
        public void And_False_False() {
            var result = GenerateCode("0 & 0");
            Assert.That(result == "0");
        }

        [Test]
        public void And_True_False() {
            var result = GenerateCode("1 & 0");
            Assert.That(result == "0");
        }
        [Test]
        public void And_False_True() {
            var result = GenerateCode("0 & 1");
            Assert.That(result == "0");
        }
        [Test]
        public void And_True_True() {
            var result = GenerateCode("1 & 2");
            Assert.That(int.Parse(result) > 0);
        }
    }
}
