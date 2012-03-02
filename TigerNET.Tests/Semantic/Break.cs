using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class Break: SemanticTest
    {
        [Test]
        public void Break_Outside_Loop() {
            var ast = Utils.BuildAST("break");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }
        
        [Test]
        public void Break_OK() {
            var ast = Utils.BuildAST("while 1 < 1 break");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void Break_Inside_Function() {
            var ast = Utils.BuildAST(@"
while 0
    let
        function f() = break
    in
    end
");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void Assign_Variable_ExpressionSequence_WithBreak() {
            var ast = Utils.BuildAST(@"

let
    var x : int := 4
in
    while x > 0 do
        x := (10 ; break ; x - 1)
end
");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void Assign_Variable_ExpressionSequence_WithBreak_2() {
            var ast = Utils.BuildAST(@"

let
    var x : int := 4
    var c : int := 4
in
    while x > 0 do
        x := (10 ; if c < 3 then break ; x - 1)
end
");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void Assign_Variable_ExpressionSequence_WithBreak_3() {
            var ast = Utils.BuildAST(@"

let
    var x : int := 4
in
    while x > 0 do
        x := (10 ; if 1 < 3 then break ; x - 1)
end
");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
        }

        [Test]
        public void Assign_Variable_ExpressionSequence_WithBreak_LoopInside() {
            var ast = Utils.BuildAST(@"

let
    var x : int := 4
in
    x := (10 ; while x > 0 do if 1 < 3 then break ; x - 1)
end
");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }
    }
}
