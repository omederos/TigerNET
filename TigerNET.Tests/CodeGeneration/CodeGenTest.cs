using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TigerNET.Core;

namespace TigerNET.Tests.CodeGeneration
{
    public class CodeGenTest {
        protected Compiler Compiler;
        public CodeGenTest() {
            Compiler = new Compiler();
        }

        /// <summary>
        /// Genera el codigo 'code' y lo guarda en el archivo 'outputFile'
        /// </summary>
        /// <param name="code"></param>
        /// <param name="outputFile"></param>
        /// <returns>El resultado del codigo</returns>
        protected string GenerateCode(string code, string outputFile = null) {
            var ast = Utils.BuildAST(code);
            outputFile = outputFile != null ? GetPath(outputFile) : GetPath("tiger_test.exe");

            if (File.Exists(outputFile)) {
                File.Delete(outputFile);
            }

            Compiler.GenerateCode(ast, outputFile);

            //Iniciando el proceso...
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(outputFile);
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            string result = p.StandardOutput.ReadToEnd().Replace("\r", "").Replace("\n", "");

            p.WaitForExit();

            return result;
        }

        protected string GetPath(string name) {
            return Path.Combine(Directory.GetCurrentDirectory(), name);
        }
    }
}
