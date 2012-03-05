using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.AST;

namespace TigerNET.Core
{
    public class Compiler {
        public void GenerateCode(ExpressionNode expressionNode, string outputFile) {
            //Nombre del fichero (includa extension)
            string filename = Path.GetFileName(outputFile);
            //Nombre del directorio donde se encuentra el fichero
            string directory = Path.GetDirectoryName(outputFile);

            //Creamos un assembly
            AppDomain domain = System.Threading.Thread.GetDomain();
            AssemblyName assemblyName = new AssemblyName
                                  {
                                      Name = filename
                                  };
            AssemblyBuilder assemblyBuilder = domain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave, directory);
            
            //Creamos un modulo
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(filename);
            moduleBuilder.CreateGlobalFunctions();
            
            //Creamos una clase 'Program'
            TypeBuilder programClassBuilder = moduleBuilder.DefineType("Program", TypeAttributes.Public | TypeAttributes.Class);
            //Creamos su constructor
            ConstructorBuilder programCtorBuilder = programClassBuilder.DefineConstructor(
                MethodAttributes.Public,
                CallingConventions.Standard,
                new Type[0]
                );
            
            //Hacemos que retorne para crearlo satisfactoriamente (sino da un error)
            var gen = programCtorBuilder.GetILGenerator();
            gen.Emit(OpCodes.Ret);

            //Creamos un metodo 'Run' (publico y no estatico) que es el que ejecutara el codigo del programa
            MethodBuilder run = programClassBuilder.DefineMethod("Run", MethodAttributes.Public, CallingConventions.HasThis,
                                                   typeof (void), new Type[0]);
            var runGen = run.GetILGenerator();

            //AHORA: El codigo generarlo en el metodo 'Run'
            expressionNode.GenerateCode(runGen, programClassBuilder);

#if DEBUG
            MethodInfo writeLine = typeof(Console).GetMethod("WriteLine", new[] { typeof(int) });
            runGen.EmitCall(OpCodes.Call, writeLine, null);
#endif

            runGen.Emit(OpCodes.Ret);

            //Creamos un metodo 'Main'
            MethodBuilder mainMethodBuilder = programClassBuilder.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static,
                                                   typeof(void), null);

            //Cogemos el ILGenerator del metodo
            ILGenerator mainGen = mainMethodBuilder.GetILGenerator();

            //Creamos una instancia de la clase 'Program'
            mainGen.Emit(OpCodes.Newobj, programCtorBuilder);
            //Llamamos al metodo 'Run' de la clase que instanciamos
            mainGen.Emit(OpCodes.Callvirt, run);
            //Retornamos
            mainGen.Emit(OpCodes.Ret);
            
            //Terminamos
            programClassBuilder.CreateType();
            assemblyBuilder.SetEntryPoint(mainMethodBuilder);
            assemblyBuilder.Save(moduleBuilder.ToString());
        }
    }
}
