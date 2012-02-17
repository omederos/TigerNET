using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace TigerNET.Tests
{
    class Program
    {
        private static bool HasSyntaxError(string file)
        {
            foreach (var x in syntax_error)
            {
                if (file.Contains(x))
                {
                    return true;
                }
            }
            return false;
        }

        private static IList<string> syntax_error;
        static void Main(string[] args) {
            var input = new ANTLRStringStream("if row[0] = 0 then 0");
            var lexer = new TigerLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TigerParser(tokens);
            var x = parser.prog();

//            Debug();
        }

        private static void Debug() {
            var files = Directory.GetFiles(@"C:\HERE\School\!4to\Complementos de Compilacion\Compilador\Test cases\Others",
                                           "*.tig");
            syntax_error = new List<string>();
            syntax_error.Add("appel_test49.tig");
            syntax_error.Add("comment_not_ended_before_program.tig");
            syntax_error.Add("break_out_of_for"); //No ponen nada dentro del let-in


            int errorsCount = 0;
            foreach (var file in files) {
                if (HasSyntaxError(file)) {
                    continue;
                }
                //                Console.WriteLine(string.Format("Testing file: {0}", file));
                var input = new ANTLRFileStream(file);
                var lexer = new TigerLexer(input);
                var tokens = new CommonTokenStream(lexer);
                var parser = new TigerParser(tokens);
                var x = parser.prog();
                if (parser.Errors.Count > 0) {
                    Console.WriteLine(string.Format("Error in file: {0}", file));
                    errorsCount++;
                    foreach (var error in parser.Errors) {
                        Console.WriteLine(string.Format("Error: {0}", error));
                    }
                    //                    Console.ReadLine();
                }

                //                else
                //                {
                //                    Console.WriteLine("OK!");
                //                }
            }

            Console.WriteLine(string.Format("Done. Errors: {0}", errorsCount));
            Console.ReadLine();
        }
    }
}
