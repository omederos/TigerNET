using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using TigerNET.AST;

namespace TigerNET.Tests
{
    static class Utils
    {
        public static ExpressionNode BuildAST(string code) {
            var input = new ANTLRStringStream(code);
            var lexer = new TigerLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TigerParser(tokens);
            return parser.prog();
        }

        public static T GetProperty<T>(ExpressionNode expr, string propName) where T : class {
            return expr.GetType().GetProperty(propName).GetValue(expr, null) as T;
        }
    }
}
