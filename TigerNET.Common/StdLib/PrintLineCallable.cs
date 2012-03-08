using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class PrintLineCallable: Callable {
        public PrintLineCallable() : base("printline", new List<TypeField>() {new TypeField("s", "string")}) {}
    }
}