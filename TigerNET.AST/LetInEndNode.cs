using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class LetInEndNode : InstructionNode, IScopeDefiner, IBreakable {
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
        /// Listado de 'grupos' de declaraciones
        /// </summary>
        protected IList<IList<DeclarationNode>> GroupedDeclarations { get; set; }
        /// <summary>
        /// Scope que define este nodo por ser IScopeDefiner
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Campo (Int32) que tendra la clase que representa a este Let-In-End
        /// </summary>
        public FieldBuilder BreakField { get; set; }

        public Label LabelEnd { get; set; }

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
            //Creamos la clase correspondiente a este Let, pues la expresion Let-In-End define un nuevo scope
            var letTypeBuilder = typeBuilder.DefineNestedType(NamesGenerator.GenerateNewName(), TypeAttributes.Public | TypeAttributes.Class);

            #region Constructor

            //Creamos el constructor de la clase, que recibe un parametro del padre
            var constructor = letTypeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard,
                                             new Type[] {typeBuilder});

            //Definimos los dos campos iniciales que tendra la clase
            //Break (Int32) -> Flag que indica si se tiene que romper romper el flujo de la ejecucion o no. Se le da valor desde un hijo (Break u otro Let-In-End)
            BreakField = typeBuilder.DefineField("Break", typeof (int), FieldAttributes.Public);
            //ParentInstance (Tipo del padre) -> Referencia a la clase padre
            ParentInstance = typeBuilder.DefineField("Parent", typeBuilder, FieldAttributes.Public);

            //Anadimos el codigo necesario en el constructor
            var genConstructor = constructor.GetILGenerator();

            //Le asignamos a ParentInstance la instancia de mi padre que me pasaron en el constructor
            genConstructor.Emit(OpCodes.Ldarg_0); //Cargamos 'this'
            genConstructor.Emit(OpCodes.Ldarg_1); //Cargamos el parametro del constructor (mi padre)
            genConstructor.Emit(OpCodes.Stfld, ParentInstance); //Cargamos el parametro del constructor (mi padre)
            
            //Le asignamos el valor '0' al campo 'Break'
            genConstructor.Emit(OpCodes.Ldarg_0); //Cargamos 'this'
            genConstructor.Emit(OpCodes.Ldc_I4, 0); //Metemos en la pila un '0'
            genConstructor.Emit(OpCodes.Stfld, BreakField); //Le asignamos el '0' al campo 'Break' de esta clase

            //Generamos todas las declaraciones ya aqui en el constructor (para que los campos sean asignados a la clase antes de ejecutar el cuerpo del Let)
            foreach (var group in GroupedDeclarations) {
                //Generamos las declaraciones usando el generador del constructor, y se guardaran en la clase ya creada para este Let
                GenerateCodeOfDeclarations(group, genConstructor, letTypeBuilder);
            }

            //Terminamos el constructor
            genConstructor.Emit(OpCodes.Ret);

            #endregion

            //El tipo de retorno del metodo que crearemos depende del tipo de retorno de esta expresion Let-In-End
            //Si no retorna nada, el metodo es Void. Sino, el metodo retorna el tipo de retorno de la expresion
            var methodReturnType = ReturnType == null ? typeof(void) : ReturnType.GetILType();
            //Creamos el metodo principal donde se ejecutara el cuerpo de este Let. No recibe parametros
            var runMethodBuilder = letTypeBuilder.DefineMethod("Run", MethodAttributes.Public, CallingConventions.HasThis,
                                                            methodReturnType, new Type[0]);

            var runGenerator = runMethodBuilder.GetILGenerator();

            //Etiqueta para donde se saltara en caso de que se interrumpa el flujo de ejecucion
            LabelEnd = runGenerator.DefineLabel();

            //Generamos el codigo de la secuencia de expresiones dentro del metodo, y dentro de la clase que creamos para el Let (logico)
            Expressions.GenerateCode(runGenerator, letTypeBuilder);

            //Aqui almacenaremos el valor de retorno del Let (si retorna)
            LocalBuilder resultLocal = null;
            //Si la secuencia de expresiones retorna algun valor
//            if (ReturnType != null) {
                //Creamos la variable donde guardaremos el valor
//                resultLocal = runGenerator.DeclareLocal(ReturnType.GetILType());
                //Asignamos el valor
//                runGenerator.Emit(OpCodes.Stloc, resultLocal);
//            }

            //Ponemos aqui la etiqueta 'END'
            runGenerator.MarkLabel(LabelEnd);

            //Aqui comprobamos si me mandaron a interrumpir el flujo de ejecucion o no...
            
            //Etiqueta a donde se saltara en caso de que no haga falta interrumpir la ejecucion
            Label lblNoBreak = runGenerator.DefineLabel();

            //Comprobamos si 'Break == 0'
            // Ver si hace falta terminar la ejecucion del padre.
            runGenerator.Emit(OpCodes.Ldarg_0); //Cargamos 'this'
            runGenerator.Emit(OpCodes.Ldfld, BreakField); //Cargamos el campo 'Break' de la clase del Let
            runGenerator.Emit(OpCodes.Ldc_I4_0); //Anadimos el 0
            runGenerator.Emit(OpCodes.Beq, lblNoBreak); //Si Break == 0, entonces no hace falta terminar. Saltar para NO_BREAK

            //Si hace falta terminar la ejecicion
            //Le asignamos el valor '0' al campo Break de esta clase
            runGenerator.Emit(OpCodes.Ldarg_0);
            runGenerator.Emit(OpCodes.Ldc_I4_0);
            runGenerator.Emit(OpCodes.Stfld, BreakField);

            //Ahora, vamos subiendo por los ParentInstance hasta llegar a uno que sea IBreakable (For, While o Let)
            //Garantizamos que siempre lleguemos, pues tambien lo chequeamos en la semantica del nodo Break.
            var expression = Parent;
            //Mientras no lleguemos a un nodo IBreakable
            while (!(expression is IBreakable)) {
                expression = expression.Parent;
            }

            //Ya tenemos en 'expression' al IScopeDefiner padre. Lo que tenemos que hacer es poner su campo 'Break' en 1
            runGenerator.Emit(OpCodes.Ldarg_0); //Cargamos 'this'
            runGenerator.Emit(OpCodes.Ldfld, ParentInstance); //Metemos en la pila la referencia a ParentInstance
            runGenerator.Emit(OpCodes.Ldc_I4, 0); //Metemos en la pila el valor '1' que le asignaremos
            runGenerator.Emit(OpCodes.Stfld, ((IBreakable) expression).BreakField); //Hacemos la asignacion

            //Terminamos el metodo principal
            runGenerator.Emit(OpCodes.Ret);
            //Creamos la clase que definimos para que pueda ser usada
            letTypeBuilder.CreateType();

            //Ahora, FUERA DE LA CLASE 'LET', instanciamos la clase Let que creamos, y llamamos al metodo principal!
            generator.Emit(OpCodes.Ldarg_0); //El constructor recibe como 1er argumento la instancia 'this'
            generator.Emit(OpCodes.Newobj, constructor); //Llamamos al constructor (y pone la referencia al nuevo tipo creado en la pila)
            generator.Emit(OpCodes.Callvirt, runMethodBuilder); //Llamamos al metodo principal

            //De la forma que lo diseñe, el valor de retorno (si hay) quedara en el tope de la pila
        }

        /// <summary>
        /// Recibe una secuencia/bloque de declaraciones y genera el codigo de estas como campos de esta clase
        /// </summary>
        /// <param name="group"></param>
        /// <param name="generator">Generador que se usara para generar el codigo</param>
        /// <param name="typeBuilder">Clase donde se guardaran las variables/funciones/tipos</param>
        private void GenerateCodeOfDeclarations(IList<DeclarationNode> group, ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Agrupar los bloques de declaraciones de funciones y de tipos por separado
            GroupedDeclarations = Declarations.GroupDeclarations();

            //Creamos un nuevo scope
            var scopeLetIn = new Scope(scope);
            //Guardamos el scope en el nodo para usarlo en la generacion de codigo
            Scope = scopeLetIn;

            int errorsCount = errors.Count;
            //Procesamos cada grupo de declaraciones
            foreach (var group in GroupedDeclarations) {
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

        //TODO: Asignarle valor en la generacion de codigo!
        public FieldBuilder ParentInstance { get; set; }
    }

    /// <summary>
    /// Representa a un nodo al cual se le puede hacer 'Break'
    /// </summary>
    public interface IBreakable {
        /// <summary>
        /// Etiqueta que indica a donde se debe saltar en caso de que se interrumpa el flujo de ejecucion
        /// </summary>
        Label LabelEnd { get; set; }
        /// <summary>
        /// Campo de la clase del nodo (Int32) que indica si es necesario interrumpir el flujo de ejecucion o no
        /// </summary>
        FieldBuilder BreakField { get; set; }
    }
}