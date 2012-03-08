using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class OrdCallable: Callable {
        public OrdCallable() : base("ord", new List<TypeField>() {new TypeField("s", "string")}, "int") {}
    }
}