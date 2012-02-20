using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class ScopeTests {
        private Scope _scope;
        [SetUp]
        public void Init() {
            _scope = new Scope();
        }

        private void AddStringVariable(string name, Scope s = null) {
            if (s == null)
                _scope.Add(name, StringType.Create());
            else {
                s.Add(name, StringType.Create());
            }
        }

        [Test]
        public void CheckLocalExistence_OneVariable() {
            AddStringVariable("x");
            Assert.That(_scope.ExistsDeclaration("x"));
        }

        [Test]
        public void CheckExistence_OneVariableInParent_TwoScopes() {
            var s = new Scope();
            AddStringVariable("x", s);
            _scope = new Scope(s);
            
            AddStringVariable("x");
            Assert.That(_scope.ExistsDeclaration("x"));
        }

        [Test]
        public void CheckExistence_OneTypeInParent_TwoScopes() {
            var s = new Scope();
            s.Add(StringType.Create());
            _scope = new Scope(s);

            Assert.That(_scope.ExistsType("string"));
            
        }
    }
}
