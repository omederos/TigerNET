using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.AST;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.Core
{
    public class Compiler {
        public void GenerateCode(ExpressionNode expressionNode, string outputFile) {
            //TODO: Eliminar este codigo
            IList<Error> errors = new List<Error>();
            expressionNode.CheckSemantic(new MainScope(), errors);
            if (errors.Count > 0) {
                throw new Exception("Semantic check error");
            }
            //Nombre del fichero (includa extension)
            string filename = Path.GetFileName(outputFile);
            //Nombre del directorio donde se encuentra el fichero
            string directory = Path.GetDirectoryName(outputFile);

            //Creamos un assembly
            AppDomain domain = System.Threading.Thread.GetDomain();
            AssemblyName assemblyName = new AssemblyName
                                  {
                                      Name = Path.GetFileNameWithoutExtension(outputFile)
                                  };
            AssemblyBuilder assemblyBuilder = domain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave, directory);
            
            //Creamos un modulo
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(filename);
            moduleBuilder.CreateGlobalFunctions();

            //Guardamos el modulo y el assembly para que lo puedan usar directamente los nodos que quieran
            Builders.Module = moduleBuilder;
            Builders.Assembly = assemblyBuilder;
            
            //Creamos una clase 'Program'
            TypeBuilder programClassBuilder = moduleBuilder.DefineType("Program", TypeAttributes.Public | TypeAttributes.Class);
            //Creamos su constructor
            var programCtorBuilder = programClassBuilder.DefineDefaultConstructor(MethodAttributes.Public);
//            ConstructorBuilder programCtorBuilder = programClassBuilder.DefineConstructor(
//                MethodAttributes.Public,
//                CallingConventions.Standard,
//                new Type[0]
//                );
            
            //Hacemos que retorne para crearlo satisfactoriamente (sino da un error)
//            var gen = programCtorBuilder.GetILGenerator();
//            gen.Emit(OpCodes.Ret);

            //Creamos un metodo 'Run' (publico y no estatico) que es el que ejecutara el codigo del programa
            MethodBuilder run = programClassBuilder.DefineMethod("Run", MethodAttributes.Public, CallingConventions.HasThis,
                                                   typeof (void), new Type[0]);
            var runGen = run.GetILGenerator();

            //AHORA: El codigo generarlo en el metodo 'Run'
            expressionNode.GenerateCode(runGen, programClassBuilder);

#if DEBUG
            Type[] types = expressionNode.ReturnType == null
                               ? new Type[0]
                               : new Type[] {expressionNode.ReturnType.GetILType()};
            MethodInfo writeLine = typeof(Console).GetMethod("WriteLine", types);
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
