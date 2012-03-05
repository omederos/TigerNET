using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.AST;

namespace TigerNET
{
    class Program {
        private static string _outputFile = "tiger_test.exe";
        static void Main(string[] args) {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\Oscar\Documents\Visual Studio 2010\Projects\ILTests\ILTests\bin\Debug\numbers.exe");
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.StandardInput.Write("\n");

            Console.WriteLine(p.StandardOutput.ReadToEnd());

            p.WaitForExit();

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
