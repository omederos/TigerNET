using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class NotCallable: Callable {
        public NotCallable() : base("not", new List<TypeField>() {new TypeField("i", "int")}, "int") {}
    }
}