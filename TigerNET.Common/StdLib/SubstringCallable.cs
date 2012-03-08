using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class SubstringCallable: Callable {
        public SubstringCallable() : base("substring", new List<TypeField>() { new TypeField("s", "string"), new TypeField("f", "int"), new TypeField("n", "int") }, "string") { }
    }
}