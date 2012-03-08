using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class SizeCallable: Callable {
        public SizeCallable() : base("size", new List<TypeField>() {new TypeField("s", "string")}, "int") {}
    }
}