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
        private string _peVerifyPath = @"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\PEVerify.exe";
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

            //Comprobando que el codigo generado este correcto con PEVerify
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\NETFX 4.0 Tools\x64\PEVerify.exe", string.Format(@"""{0}""", outputFile));
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            string result = p.StandardOutput.ReadToEnd();

            p.WaitForExit();


            //Iniciando el proceso...
            p = new Process();
            p.StartInfo = new ProcessStartInfo(outputFile);
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            result = p.StandardOutput.ReadToEnd().Replace("\r", "").Replace("\n", "");

            p.WaitForExit();

            return result;
        }

        protected string GetPath(string name) {
            return Path.Combine(Directory.GetCurrentDirectory(), name);
        }
    }
}
