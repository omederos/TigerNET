using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public interface IScopeDefiner {
        //Scope asociado al nodo actual
        Scope Scope { get; set; }
        //Instancia del padre del nodo actual (en IL)
        FieldBuilder ParentInstance { get; set; }
    }

    public class LetInEndNode : InstructionNode, IScopeDefiner {
        /// <summary>
        /// Declaraciones dentro del LET - IN
        /// </summary>
        public IList<DeclarationNode> Declarations { get; set; }

        private ExpressionSequenceNode _expressions;

        /// <summary>
        /// Expresiones a ejecutar dentro del IN - END
        /// </summary>
        public ExpressionSequenceNode Expressions {
            get { return _expressions; }
            set {
                _expressions = value;
                if (_expressions != null) {
                    _expressions.Parent = this;
                }
            }
        }

        /// <summary>
        /// Util en las pruebas unitarias solamente!
        /// </summary>
        public Scope CurrentScope { get; set; }


        public LetInEndNode(IList<DeclarationNode> declarations, ExpressionSequenceNode expressions) {
            Declarations = declarations;
            Expressions = expressions;

            Expressions.Parent = this;

            foreach (var dec in Declarations) {
                dec.Parent = this;
            }
        }

        public LetInEndNode(IList<DeclarationNode> declarations) : this(declarations, new ExpressionSequenceNode()) {}

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Agrupar los bloques de declaraciones de funciones y de tipos por separado
            var groups = Declarations.GroupDeclarations();

            //Creamos un nuevo scope
            var scopeLetIn = new Scope(scope);
            CurrentScope = scopeLetIn;
            
            //Guardamos el scope en el nodo para usarlo en la generacion de codigo
            Scope = scopeLetIn;

            int errorsCount = errors.Count;
            //Procesamos cada grupo de declaraciones
            foreach (var group in groups) {
                Process(group, scopeLetIn, errors);
            }

            //Si ocurrio algun error en el conjunto de definiciones...
            if (errorsCount != errors.Count) {
                return;
            }

            //Chequeamos semanticamente la secuencia de expresiones
            Expressions.CheckSemantic(scopeLetIn, errors);

            ReturnType = Expressions.ReturnType;
        }

        /// <summary>
        /// Procesa un conjunto de declaraciones de un mismo tipo
        /// </summary>
        /// <param name="group"></param>
        /// <param name="scope"> </param>
        private void Process(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            var first = group[0];
            //TODO: Refactorizar: Usar clases en vez de if - else if - else if...
            //Si es un grupo de declaraciones de variables
            if (first is VariableDeclarationNode) {
                ProcessVariableDeclarations(group, scope, errors);
            }
                //Si es un grupo de declaraciones de funciones/procedimientos
            else if (first is CallableDeclarationNode) {
                ProcessCallableDeclarations(group, scope, errors);
            }
                //Si es un grupo de declaraciones de tipos (records, arrays, etc)
            else {
                ProcessTypeDeclarations(group, scope, errors);
            }
        }

        private void ProcessTypeDeclarations(IList<DeclarationNode> groupOfDeclarations, Scope scope,
                                             IList<Error> errors) {
            int errorsCount = 0;

            //Anadimos los encabezados de las declaraciones de los tipos
            //Y a la vez, comprobamos que no exista un tipo con ese nombre (en este scope solamente)
            foreach (var dec in groupOfDeclarations) {
                if (scope.ExistsType(dec.Name, false)) {
                    errors.Add(new AlreadyDefinedError(dec.Line, dec.Column, dec.Name));
                    break;
                }
                scope.Add(null, dec.Name);
            }

            //Si ocurrio algun error, paramos
            if (errorsCount != errors.Count) {
                return;
            }

            //Separamos los alias y las declaraciones de array/records..

            //Listado de declaraciones que no son alias
            var notAliasDeclarations = groupOfDeclarations.Where(x => !(x is AliasDeclarationNode)).ToList();
            //Listadoo de declaraciones que son alias
            var aliasDeclarations = groupOfDeclarations.OfType<AliasDeclarationNode>().ToList();

            /* Procesamos los alias primero, y obtenemos varios conjuntos de alias
             * En un mismo conjunto estaran los alias que hacen referencia entre ellos
             * El primer elemento del conjunto sera el alias por el que se empezo a analizar
             * El ultimo elemento sera el que desembocó en un tipo existente/valido
             * 
             * Ejemplo: 
             * 
             * type r = {x : a}
             * type a = b
             * type c = r
             * type b = c
             * 
             * Aqui obtendremos un solo conjunto con las declaraciones: {a = b} {b = c} {c = r}
            */
            IList<List<AliasDeclarationNode>> aliasesGroups = ProcessAliasesGroup(aliasDeclarations, scope, errors);

            //Si ocurrio algun error, paramos
            if (errorsCount != errors.Count) {
                return;
            }

            //Chequeamos semanticamente cada tipo (que no sea alias)
            //Todos los tipos posibles a los que pueden hacer referencia han sido anadidos al scope
            foreach (var declaration in notAliasDeclarations) {
                declaration.CheckSemantic(scope, errors);
            }

            //Si hubo algun error
            if (errorsCount != errors.Count) {
                return;
            }

            //Por cada grupo de alias, vamos de atras hacia delante resolviendo los tipos
            //Pues el ultimo en cada grupo es el que apuntaba hacia un tipo valido (y no hacia otro alias)
            foreach (var aliasGroup in aliasesGroups) {
                for (int i = aliasGroup.Count - 1; i >= 0; i--) {
                    var alias = aliasGroup[i];
                    //Actualizamos la definicion del tipo en el scope
                    alias.UpdateDefinition(scope);
                }
            }

            //Actualizamos las declaraciones de los no-alias
            foreach (var declaration in notAliasDeclarations) {
                var t = (TypeDeclarationNode) declaration;
                //Actualizamos la definicion del tipo en el scope
                t.UpdateDefinition(scope);
            }
        }

        private void ProcessCallableDeclarations(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            //Por cada procedimiento o funcion en el bloque...
            int errorsCount = errors.Count;
            foreach (CallableDeclarationNode c in group) {
                //Chequeamos la semantica de la funcion. 
                //OJO: No chequea la semantica del cuerpo de la funcion
                c.CheckSemantic(scope, errors);
                //Si ocurrio algun error chequeando la semantica de la funcion (en la 1ra pasada)
                if (errorsCount != errors.Count) {
                    return;
                }
            }

            //Hacemos una segunda pasada para chequear los cuerpos de las funciones (una vez ya definidas formalmente todas las funciones del bloque)
            //Y ver que el tipo de retorno de la funcion sea igual al especificado
            foreach (CallableDeclarationNode c in group) {
                errorsCount = errors.Count;
                c.CheckBodySemantic(scope, errors);

                //Si hubo algun error, eliminamos esa funcion del scope. TODO: Necesario?
                if (errorsCount != errors.Count) {
                    scope.DefinedCallables.Remove(c.Name);
                }
            }
        }

        private void ProcessVariableDeclarations(IList<DeclarationNode> group, Scope scope, IList<Error> errors) {
            //Las variables no necesitan un trato especial
            foreach (var dec in @group) {
                dec.CheckSemantic(scope, errors);
            }
        }

        /// <summary>
        /// Encargado de recibir un conjunto de declaraciones de tipo alias (pertenecientes a un mismo bloque)
        /// y chequear que no haya ciclos, etc.
        /// </summary>
        /// <param name="aliasDeclarations">Conjunto de alias</param>
        /// <param name="scope"></param>
        /// <param name="errors"></param>
        /// <returns>Varios conjunticos de alias donde en cada conjunto estan los relacionados. Ademas, estan en el orden que se fueron resolviendo</returns>
        private IList<List<AliasDeclarationNode>> ProcessAliasesGroup(IList<AliasDeclarationNode> aliasDeclarations,
                                                                      Scope scope, IList<Error> errors) {
            //Donde guardaremos los conjunticos
            var result = new List<List<AliasDeclarationNode>>();

            //Si no hay ningun Alias declaration
            if (aliasDeclarations.Count == 0) {
                return result;
            }

            //Creamos el primer conjunto
            result.Add(new List<AliasDeclarationNode>());

            //Convertimos los alias a un diccionario (para facilitar el manejo) de la forma:
            //{ Name : AliasDeclarationNode }
            var dictAliases = aliasDeclarations.ToDictionary(x => x.Name, x => x);

            //Cogemos el primer alias
            AliasDeclarationNode alias = aliasDeclarations[0];

            //Mientras queden alias por analizar
            while (dictAliases.Count > 0) {
                //Tipo al que apunta
                var type = alias.AliasType;

                //Si no existe el tipo, paramos
                if (!scope.ExistsType(type)) {
                    errors.Add(new UndefinedTypeError(Line, Column, type));
                    break;
                }

                //Si el tipo ya ha sido definido correctamente o si no ha sido definido completamente pero no apunta a ningun alias (ej. apunta a un record que esta por definirse)
                if (IsFullyDefined(type, scope) || DoesNotPointToAlias(type, aliasDeclarations)) {
                    //Cogemos el tipo al que apunta
                    var t = scope.GetType(type);
                    //Anadimos este alias diciendo que apunta a aquel tipo
                    scope.Add(t, alias.Name, updateIfExists: true);
                    //Anadimos el alias al grupo actual
                    result[result.Count - 1].Add(alias);
                    //Lo eliminamos de los procesados (ya acabamos con el)
                    dictAliases.Remove(alias.Name);
                    //Ya actualizamos el que apunta a un tipo que no es alias
                    //Ahora vamos de atras hacia delante por la cadena y actualizamos el tipo de todos
                    for (int i = result[result.Count - 1].Count - 1; i >= 0; i--) {
                        //Cogemos el i-esimo alias
                        var a = result[result.Count - 1][i];
                        //Cogemos el tipo al que apunta
                        t = scope.GetType(a.AliasType);
                        //Actualizamos el alias, diciendo que va a ser del mismo tipo al que el apunta
                        scope.Add(t, a.Name, updateIfExists: true);
                        //Ya no procesaremos mas este alias
                        dictAliases.Remove(a.Name);
                    }

                    //Creamos un nuevo grupo
                    result.Add(new List<AliasDeclarationNode>());
                    if (dictAliases.Count != 0) {
                        //Si todavia quedan alias por analizar, nos quedamos con uno cualquiera
                        alias = dictAliases[dictAliases.First().Key];
                    }
                }
                    //Si el tipo apunta no ha sido 100% definido y esta apuntando a un tipo que es una alias...
                else {
                    //Lo anadimos al grupo actual
                    result[result.Count - 1].Add(alias);
                    //Cogemos el proximo (al que el apunta)
                    alias = dictAliases[alias.AliasType];
                    //Si ese tipo al que apunta ya ha sido anadido en este grupo => Hay un ciclo
                    //Notar que si estuviera en otro grupo, no hubiera problema, porque significa que ya fue resuelto correctamente sin siclos
                    if (result[result.Count - 1].Contains(alias)) {
                        //Existe un ciclo y terminamo
                        errors.Add(new CyclicAliasesError(alias.Line, alias.Column));
                        break;
                    }
                }
            }

            return result;
        }

        private bool DoesNotPointToAlias(string type, IList<AliasDeclarationNode> aliases) {
            return aliases.Count(x => x.Name == type) == 0;
        }

        private bool IsFullyDefined(string type, Scope scope) {
            return scope.ExistsType(type) && scope.GetType(type) != null;
        }

        public Scope Scope { get; set; }

        //TODO: Asignarle valor en la generacion de codigo!
        public FieldBuilder ParentInstance { get; set; }
    }
}