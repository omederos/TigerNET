using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class CallableDeclaration : SemanticTest {
        [Test]
        public void Procedure_NoParameters_Int() {
            var ast = Utils.BuildAST("let function f() = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsDeclaration("f"));
            Assert.That(Scope.DefinedCallables["f"].Fields.Count == 0);
            Assert.That(Scope.DefinedCallables["f"].Name == "f");
            Assert.That(Scope.DefinedCallables["f"].Type == null);
        }
        [Test]
        public void Procedure_OneStringParameter_Int()
        {
            var ast = Utils.BuildAST("let function f(a:string) = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == null);
            Assert.That(Scope.ExistsDeclaration("f"));
            Assert.That(Scope.DefinedCallables["f"].Fields.Count == 1);
            Assert.That(Scope.DefinedCallables["f"].Fields[0].Id == "a");
            Assert.That(Scope.DefinedCallables["f"].Fields[0].TypeId == "string");
            Assert.That(Scope.DefinedCallables["f"].Name == "f");
            Assert.That(Scope.DefinedCallables["f"].Type == null);
        }

        [Test]
        public void Procedure_DuplicateParameters_Int()
        {
            var ast = Utils.BuildAST("let function f(a:string, a:int) = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is DuplicateParameterError);
            Assert.That(dec.ReturnType == null);
            Assert.That(!Scope.ExistsDeclaration("f"));
        }

        [Test]
        public void Procedure_UndefinedParameterType_Int()
        {
            var ast = Utils.BuildAST("let function f(a:someType) = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(dec.ReturnType == null);
            Assert.That(!Scope.ExistsDeclaration("f"));
        }

        [Test]
        public void Function_NoParameters_Int()
        {
            var ast = Utils.BuildAST("let function f() : int = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(dec.ReturnType == IntegerType.Create());
            Assert.That(Scope.ExistsDeclaration("f"));
            Assert.That(Scope.DefinedCallables["f"].Fields.Count == 0);
            Assert.That(Scope.DefinedCallables["f"].Name == "f");
            Assert.That(Scope.DefinedCallables["f"].Type == "int");
        }

        [Test]
        public void Function_DifferentTypes_String_Int()
        {
            var ast = Utils.BuildAST("let function f() : string = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is NotMatchingTypesError);
            Assert.That(dec.ReturnType == null);
            Assert.That(!Scope.ExistsDeclaration("f"));
        }

        [Test]
        public void Function_UndefinedReturnType_Int()
        {
            var ast = Utils.BuildAST("let function f() : someType = 1");
            var dec = Utils.GetFirstDeclaration(ast);
            dec.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
            Assert.That(dec.ReturnType == null);
            Assert.That(!Scope.ExistsDeclaration("f"));
        }
    }
}
