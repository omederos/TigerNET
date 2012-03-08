using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    public class ExpressionSequenceNode : CodeGenTest
    {
        [Test]
        public void OneExpression() {
            var result = GenerateCode(@"
let
    var x := 10
in
    2
");
            Assert.That(result == "2");
        }
        
        [Test]
        public void Two_Expressions() {
            var result = GenerateCode(@"
let
    var x := 10
in
    2;3
");
            Assert.That(result == "3");
        }
        
        [Test]
        public void Three_Expressions() {
            var result = GenerateCode(@"
let
    var x := 10
in
    2;3;4
");
            Assert.That(result == "4");
        }

        //TODO: Pruebas unitarias cuando no se retorne nada
    }
}
