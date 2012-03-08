using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class ConcatCallable: Callable {
        public ConcatCallable() : base("concat", new List<TypeField>() { new TypeField("s1", "string"), new TypeField("s2", "string") }, "string") { }
    }
}