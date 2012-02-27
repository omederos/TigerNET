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
    class RecordLiteral : SemanticTest
    {
        [Test]
        public void Record_OK()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = { name : string, lastname : string }
                                                    in
                                                        p{name = ""Oscar"", lastname = ""Mederos""}
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 0);
            Assert.That(ast.ReturnType is RecordType);
        }

        [Test]
        public void Incorrect_Number_Of_Arguments()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = { name : string, lastname : string }
                                                    in
                                                        p{name = ""Oscar"", lastname = ""Mederos"", other = 123}
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is MessageError);
        }

        [Test]
        public void Wrong_Argument_Type()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = { name : string, lastname : string }
                                                    in
                                                        p{name = 123, lastname = ""Mederos""}
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UnexpectedTypeError);
        }

        [Test]
        public void Non_Existing_Record()
        {
            var ast = (LetInEndNode)Utils.BuildAST(@"let
                                                        type p = { name : string, lastname : string }
                                                    in
                                                        p1{name = 123, lastname = ""Mederos""}
                                                    end");
            ast.CheckSemantic(Scope, Errors);
            Assert.That(Errors.Count == 1);
            Assert.That(Errors[0] is UndefinedTypeError);
        }
    }
}
