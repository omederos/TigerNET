using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class PrintCallable : Callable {
        public PrintCallable() : base("print", new List<TypeField>() {new TypeField("s", "string")}) {}
    }
}