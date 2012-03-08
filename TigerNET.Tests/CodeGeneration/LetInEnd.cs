﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TigerNET.Tests.CodeGeneration
{
    public class LetInEnd : CodeGenTest
    {
        [Test]
        public void Declare_3_Variables_And_Sum_Them() {
            var result = GenerateCode(@"
let
    var x := 10
    var y := x
    var z := 20
in
    x+y+z
");
            Assert.That(result == "40");
        }
    }
}