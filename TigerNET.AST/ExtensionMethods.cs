using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Agrupa un conjunto de declaraciones en varios grupos consecutivos segun el tipo
        /// </summary>
        /// <param name="declarations"></param>
        /// <returns></returns>
        public static IList<IList<DeclarationNode>> GroupDeclarations(this IList<DeclarationNode> declarations) {
            IList<IList<DeclarationNode>> result = new List<IList<DeclarationNode>>();
            result.Add(new List<DeclarationNode>());
            
            if (declarations.Count == 0) {
                return result;
            }

            int currentIndex = 0;

            Type currentType = declarations[0].GetType();
            result[currentIndex].Add(declarations[0]);


            for (int i = 1; i < declarations.Count; i++) {
                var dec = declarations[i];
                //Si son el mismo tipo
                //O si ambos son herederos de TypeDeclarationNode (ambos son declaraciones de tipos)
                if (dec.GetType() == currentType || dec.GetType().IsSubclassOf(typeof(TypeDeclarationNode)) && currentType.IsSubclassOf(typeof(TypeDeclarationNode)))
                {
                    result[currentIndex].Add(dec);
                }
                //Sino
                else {
                    result.Add(new List<DeclarationNode>());
                    currentIndex++;
                    currentType = dec.GetType();
                    result[currentIndex].Add(dec);
                }
            }

            return result;
        }
    }
}
