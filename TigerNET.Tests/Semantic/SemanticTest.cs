using System.Collections.Generic;
using NUnit.Framework;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic {
    public class SemanticTest {
        protected Scope Scope;
        protected IList<Error> Errors;

        [SetUp]
        public void Init()
        {
            Scope = new MainScope();
            Errors = new List<Error>();
        }
    }
}