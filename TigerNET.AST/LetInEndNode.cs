using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class LetInEndNode : InstructionNode
    {
        /// <summary>
        /// Declaraciones dentro del LET - IN
        /// </summary>
        public IList<DeclarationNode> Declarations { get; set; }
        /// <summary>
        /// Expresiones a ejecutar dentro del IN - END
        /// </summary>
        public ExpressionSequenceNode Expressions { get; set; }

        public LetInEndNode(IList<DeclarationNode> declarations, ExpressionSequenceNode expressions) {
            Declarations = declarations;
            Expressions = expressions;
        }
        public LetInEndNode(IList<DeclarationNode> declarations) : this(declarations, new ExpressionSequenceNode()) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Agrupar los bloques de declaraciones de funciones y de tipos por separado
            var groups = Declarations.GroupDeclarations();

            //Creamos un nuevo scope
            var scopeLetIn = new Scope(scope);

            //Procesamos cada grupo de declaraciones
            foreach (var group in groups) {
                Process(group, scopeLetIn, errors);
            }
        }

        /// <summary>
        /// Procesa un conjunto de declaraciones de un mismo tipo
        /// </summary>
        /// <param name="group"></param>
        private void Process(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            var first = group[0];
            //TODO: Refactorizar: Usar clases en vez de if - else if - else if...
            //Si es un grupo de declaraciones de variables
            if (first is VariableDeclarationNode) {
                ProcessVariableDeclarations(group, scope, errors);
            }
            //Si es un grupo de declaraciones de funciones/procedimientos
            else if (first is CallableDeclarationNode)
            {
                ProcessCallableDeclarations(group, scope, errors);
            }
            //Si es un grupo de declaraciones de tipos (records, arrays, etc)
            else {
                ProcessTypeDeclarations(group, scope, errors);
            }
        }

        private void ProcessTypeDeclarations(IList<DeclarationNode> @group, Scope scope, IList<Error> errors) {
            int errorsCount = 0;
            
            foreach (var dec in group) {
                if (scope.ExistsType(dec.Name)) {
                    errors.Add(new AlreadyDefinedError(dec.Line, dec.Column, dec.Name));
                }
            }
            //Si ocurrio algun error
            if (errorsCount != errors.Count) {
                return;
            }

            //Anadimos los encabezados de las declaraciones de los tipos
            foreach (var declaration in group)
            {
                scope.Add(null, declaration.Name);
            }

            //Chequeamos semanticamente cada tipo
            foreach (var declaration in group)
            {
                declaration.CheckSemantic(scope, errors);
            }

            //Actualizamos las declaraciones
            foreach (var declaration in group)
            {
                var t = (TypeDeclarationNode)declaration;
                t.UpdateDefinition(scope);
            }
        }

        private void ProcessCallableDeclarations(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }

        private void ProcessVariableDeclarations(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            //Las variables no necesitan un trato especial
            foreach (var dec in group) {
                dec.CheckSemantic(scope, errors);
            }
        }
    }
}
