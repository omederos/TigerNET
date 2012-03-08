using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class PrintIntegerCallable: Callable {
        public PrintIntegerCallable() : base("printi", new List<TypeField>() {new TypeField("i", "int")}) {}
    }
}