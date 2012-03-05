using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.AST;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.CodeGeneration
{
    public class IfThenElse : CodeGenTest
    {
        [Test]
        public void Both_GoesWithThen() {
            var result = GenerateCode("if 1 then 10 else 2");
            Assert.That(result == "10");
        }
        [Test]
        public void Both_GoesWithElse() {
            var result = GenerateCode("if 0 then 10 else 2");
            Assert.That(result == "2");
        }
        //TODO: Para probar mas cosas, terminar el chequeo de mas nodos, y ademas implementar 'print', etc para poder probar bien...

//        [Test]
//        public void NoElse_ThenReturningValue()
//        {
//            var ast = Utils.BuildAST("if 1 < 2 then 0");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 1);
//        }
//
//        [Test]
//        public void Else_DifferentTypes()
//        {
//            var ast = Utils.BuildAST(@"if 1 < 2 then 0 else ""Hello""");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 1);
//        }
//        [Test]
//        public void Else_SameTypes_OK()
//        {
//            var ast = Utils.BuildAST("if 1 < 2 then 0 else 1");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 0);
//            Assert.That(ast.ReturnType is IntegerType);
//        }
//        [Test]
//        public void Else_NoReturn_OK()
//        {
//            var ast = Utils.BuildAST("if 1 < 2 then () else (2;())");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 0);
//            Assert.That(!ast.ReturnsValue());
//        }
//        
//        [Test]
//        public void Then_Returns_Record_Else_Returns_Nil()
//        {
//            var ast = Utils.BuildAST(@"
//let 
//    type x = {x : int}
//in 
//    if 1 < 2 then x{x = 0} else nil
//end");
//            ast.CheckSemantic(Scope, Errors);
//            Assert.That(Errors.Count == 0);
//        }

    }
}
