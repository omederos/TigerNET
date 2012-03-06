using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    class RelationalBinaryOperator : CodeGenTest
    {
        [Test]
        public void Equals_Yes_Int_Int() {
            var result = GenerateCode("2 = 2");
            Assert.That(result == "1");
        }

        [Test]
        public void Equals_NO_Int_Int() {
            var result = GenerateCode("-3 = 3");
            Assert.That(result == "0");
        }

//        [Test]
//        public void Equals_NO_String_String() {
//            var result = GenerateCode(@"""abc"" = ""abc""");
//            Assert.That(result == "0");
//        }
        [Test]
        public void NotEquals_YEs_Int_Int() {
            var result = GenerateCode("3 <> 2");
            Assert.That(result == "1");
        }

        [Test]
        public void NotEquals_NO_Int_Int() {
            var result = GenerateCode("3 <> 3");
            Assert.That(result == "0");
        }

        [Test]
        public void Greather_NO_Int_Int() {
            var result = GenerateCode("3 > 3");
            Assert.That(result == "0");
        }
        [Test]
        public void Greather_Yes_Int_Int() {
            var result = GenerateCode("4 > 3");
            Assert.That(result == "1");
        }
        [Test]
        public void Greather_No_String_String() {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}>{1}", a, b));
            Assert.That(result == "0");
        }
        [Test]
        public void Greather_Yes_String_String() {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}>{1}", b, a));
            Assert.That(result == "1");
        }
        [Test]
        public void Lower_NO_Int_Int() {
            var result = GenerateCode("3 < 3");
            Assert.That(result == "0");
        }
        [Test]
        public void Lower_Yes_Int_Int() {
            var result = GenerateCode("3 < 4");
            Assert.That(result == "1");
        }
        [Test]
        public void Lower_No_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}<{1}", b,a));
            Assert.That(result == "0");
        }
        [Test]
        public void Lower_Yes_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}<{1}", a, b));
            Assert.That(result == "1");
        }
        [Test]
        public void LowerThan_NO_Int_Int() {
            var result = GenerateCode("4 <= 3");
            Assert.That(result == "0");
        }
        [Test]
        public void LowerThan_Yes_Int_Int() {
            var result = GenerateCode("3 <= 4");
            Assert.That(result == "1");
        }
        [Test]
        public void LowerThan_Yes_Int_Int_2() {
            var result = GenerateCode("3 <= 4");
            Assert.That(result == "1");
        }
        [Test]
        public void LowerThan_No_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}<={1}", b,a));
            Assert.That(result == "0");
        }
        [Test]
        public void LowerThan_Yes_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}<={1}", a, b));
            Assert.That(result == "1");
        }
        [Test]
        public void LowerThan_Yes_String_String_2()
        {
            string a = @"""abc""";
            string b = @"""abc""";
            var result = GenerateCode(string.Format("{0}<={1}", a, b));
            Assert.That(result == "1");
        }
        [Test]
        public void GreatherThan_Yes_Int_Int() {
            var result = GenerateCode("4 >= 3");
            Assert.That(result == "1");
        }
        [Test]
        public void GreatherThan_No_Int_Int() {
            var result = GenerateCode("3 >= 4");
            Assert.That(result == "0");
        }
        [Test]
        public void GreatherThan_No_Int_Int_2() {
            var result = GenerateCode("3 >= 4");
            Assert.That(result == "0");
        }
        [Test]
        public void GreatherThan_Yes_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}>={1}", b,a));
            Assert.That(result == "1");
        }
        [Test]
        public void GreatherThan_No_String_String()
        {
            string a = @"""abc""";
            string b = @"""abd""";
            var result = GenerateCode(string.Format("{0}>={1}", a, b));
            Assert.That(result == "0");
        }
        [Test]
        public void GreatherThan_Yes_String_String_2()
        {
            string a = @"""abc""";
            string b = @"""abc""";
            var result = GenerateCode(string.Format("{0}>={1}", a, b));
            Assert.That(result == "1");
        }
    }
}
