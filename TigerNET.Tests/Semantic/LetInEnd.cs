using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    class LetInEnd : SemanticTest
    {   
        [Test]        
        public void Recursive_TwoRecords_OneArray_OK() {
            var ast = Utils.BuildAST("let type a = {x : b} type b = { y : a } type c = array of a in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }

        [Test]
        public void Recursive_TwoRecords_OneArray_OneVar_OK()
        {
            var ast = Utils.BuildAST("let type a = {x : b} type b = { y : a } type c = array of a var x := 1 in end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
        }
    }
}
