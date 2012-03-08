using System;
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

        [Test]
        public void Declare_One_Record() {
            var result = GenerateCode(@"
let
    type r = {x : int, y : string}
    var x := r{x = 10, y = ""hello""}
in
    x.y
");
            //TODO: Cambiar si le asigno nombres a los records (r1, r2, etc)
            Assert.That(result == "hello");
        }
        [Test]
        public void Declare_One_Array() {
            var result = GenerateCode(@"
let
    type a = array of int
    var x := a[10] of 20
    /*var x := 2*/
in
    x
end");
            //TODO: Cambiar si le asigno nombres a los records (r1, r2, etc)
            Assert.That(result.Length > 0);
        }
    }
}
