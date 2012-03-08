using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class ChrCallable: Callable {
        public ChrCallable() : base("chr", new List<TypeField>() {new TypeField("i", "int")}, "string") {}
    }
}