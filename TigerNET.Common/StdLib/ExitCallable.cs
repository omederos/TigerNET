using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class ExitCallable: Callable {
        public ExitCallable() : base("exit", new List<TypeField>() {new TypeField("i", "int")}) {}
    }
}