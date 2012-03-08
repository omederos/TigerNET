using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TigerNET.Common.StdLib;

namespace TigerNET.Common.Types
{
    public class MainScope : Scope {
        public MainScope()
            : base(null) {
            FillStandardLibrary();
        }

        private void FillStandardLibrary() {
            //Anadimos al scope las funciones de la biblioteca estandard
            DefinedCallables = new Dictionary<string, Callable>()
                                   {
                                       {"print", new PrintCallable()},
                                       {"printi", new PrintIntegerCallable()},
                                       {"getchar", new GetCharCallable()},
                                       {"getline", new GetLineCallable()},
                                       {"printline", new PrintLineCallable()},
                                       {"chr", new ChrCallable()},
                                       {"concat", new ConcatCallable()},
                                       {"exit", new ExitCallable()},
                                       {"flush", new FlushCallable()},
                                       {"not", new NotCallable()},
                                       {"ord", new OrdCallable()},
                                       {"size", new SizeCallable()},
                                       {"substring", new SubstringCallable()},
                                   };
            //Anadimos al scope los tipos predefinidos
            DefinedTypes = new Dictionary<string, TigerType>()
                               {
                                   {"string", StringType.Create()},
                                   {"int", IntegerType.Create()}
                               };
        }
    }
}
