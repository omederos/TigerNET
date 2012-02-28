using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class RecordAccess : SemanticTest
    {
        [Test]
        public void Record_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r = {x : int} 
    var y := r{x = 2}
in
    y.x
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is IntegerType);
        }

        [Test]
        public void Invalid_Field_Name()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r = {x : int} 
    var y := r{x = 2}
in
    y.field
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is FieldNotFoundError);
        }
        
        [Test]
        public void Accessing_No_Record()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"
let 
    type r = array of int 
    var y := r[10] of 0
in
    y.x
end");

            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }
    }
}
