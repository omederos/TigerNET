using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class CallableDeclarationNode : DeclarationNode, IScopeDefiner {
        /// <summary>
        /// Campos de la funcion/procedimiento
        /// </summary>
        public IList<TypeField> Fields { get; set; }
        /// <summary>
        /// En caso de ser una funcion, representa el tipo (dentro del programa) de esta
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// El cuerpo de la funcion
        /// </summary>
        public ExpressionNode Body { get; set; }

        /// <summary>
        /// Guarda la funcion creada una vez pasado el chequeo semantico, para poder ser usada en la generacion de codigo
        /// </summary>
        public Callable Callable { get; set; }

        public CallableDeclarationNode(string name, IList<TypeField> fields, ExpressionNode body, string type = null) : base(name) {
            Fields = fields;
            Type = type;
            Body = body;
            Body.Parent = this;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder)
        {
            #region Generando constructor
            
            //Ya tenemos creado el campo 'ParentInstance', que es una referencia al padre.
            //Ahora lo que hacemos es darle el valor que me pasaron (como 1er parametro) en el constructor
            var genConstructor = Callable.Constructor.GetILGenerator();

            //Cargamos 'this'
            genConstructor.Emit(OpCodes.Ldarg_0);
            //Cargamos la instancia del padre
            genConstructor.Emit(OpCodes.Ldarg_1);
            //Asignamos a ParentInstance el valor anterior
            genConstructor.Emit(OpCodes.Stfld, ParentInstance);

            //Le damos valor a cada parametro que me pasan en el constructor
            int index = 1;
            foreach (var keyPair in Callable.FieldsInClass) {
                genConstructor.Emit(OpCodes.Ldarg_0); //Cargamos a 'this'
                genConstructor.Emit(OpCodes.Ldarg, index); //Cargamos el parametro 'i-esimo' (empezando en 1)
                genConstructor.Emit(OpCodes.Stfld, keyPair.Value); //Le asignamos el valor al campo correspondiente
                index++;
            }

            //Salimos del constructor
            genConstructor.Emit(OpCodes.Ret);
            
            #endregion

            #region Generando cuerpo de la funcion
            
            //Cogemos un generador del metodo principal de la funcion
            ILGenerator genBody = Callable.Method.GetILGenerator();

            //Generamos el cuerpo usando el generador anterior y el TypeBuilder asociado la clase que define esta funcion
            Body.GenerateCode(genBody, Callable.ILCallable);

            //Terminamos
            genBody.Emit(OpCodes.Ret);

            #endregion

            //Creamos la clase para que pueda ser usada
            Callable.ILCallable.CreateType();
        }

        /// <summary>
        /// Crea una clase que representara a esta funcion
        /// Este metodo debe ser llamado antes de llamar al GenerateCode
        /// </summary>
        /// <param name="typeBuilder"></param>
        public void CreateCallableClass(TypeBuilder typeBuilder) {
            //Las funciones debemos declararlas en un scope anidado, es decir, que sea una clase anidada
            //Guardamos la funcion que definimos en la informacion de este callable
            Callable.ILCallable = typeBuilder.DefineNestedType(Callable.GetName(), TypeAttributes.NestedPublic | TypeAttributes.Class);

            //Como estamos definiendo un nuevo scope, y a veces sera necesario subir hacia los scopes padres, es necesario recibir una instancia del scope anterior
            ParentInstance = Callable.ILCallable.DefineField(NamesGenerator.GenerateNewName(), typeBuilder,
                                                             FieldAttributes.Public);

            //El constructor recibira tantos parametros como reciba la funcion
            //Para poder generar el constructor, definimos primeramente los campos que almacenara esta clase (los parametros)
            Callable.FieldsInClass = new Dictionary<string, FieldBuilder>(); //Donde guardaremos los campos definidos en esta clase asociados a esta funcion
            //Lista de tipos que recibira el constructor
            IList<Type> realTypesOfParameters = new List<Type>();
            //Lo primero que recibe es la instancia del padre
            realTypesOfParameters.Add(typeBuilder);

            foreach (var field in Callable.Fields) {
                //Cogemos el tipo del parametro actual. No era necesario hacerlo desde el chequeo semantico pues aqui tenemos el Scope por ser un IScopeDefiner
                var type = Scope.GetType(field.TypeId).GetILType();
                realTypesOfParameters.Add(type); //Anadimos el tipo (en C#) de este parametro para pasarselo al constructor (el Type[] que recibe)
                //Creamos el campo en la clase
                string name = NamesGenerator.GenerateNewName(); //Nombre del campo
                var fieldBuilder = Callable.ILCallable.DefineField(name, type, FieldAttributes.Public); //Tipo del campo
                Callable.FieldsInClass.Add(name, fieldBuilder);
            }

            //Ahora creamos el constructor, de forma similar a como hicimos con el RecordDeclarationNode
            ConstructorBuilder constructor = Callable.ILCallable.DefineConstructor(MethodAttributes.Public,
                                                                                   CallingConventions.Standard,
                                                                                   realTypesOfParameters.ToArray());
            //Guardamos el constructor en la informacion de este callable para cuando se vaya a instanciar
            //Y ademas para cuando se ejecute el metodo CheckSemantic de este mismo nodo
            Callable.Constructor = constructor;

            //Creamos el cuerpo de la funcion (un metodo en esta clase)
            //El metodo sera publico y no estatico
            //Le asignamos el tipo de retorno que retorna esta funcion en caso de que no sea un procedimiento
            var returnType = Callable.Type == null ? typeof (void) : Scope.GetType(Callable.Type).GetILType();
            var methodBuilder = Callable.ILCallable.DefineMethod("Run", MethodAttributes.Public, //TODO: HideBySig?
                returnType, new Type[0]);
            //Asignamos el metodo principal de esta funcion a la informacion de la funcion
            Callable.Method = methodBuilder;
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobamos que no exista una variable/funcion en este mismo scope definida
            if (scope.ExistsVariableOrCallable(Name, false)) {
                errors.Add(new AlreadyDefinedError(Line, Column, Name));
                return;
            }
            
            int errorsCount = errors.Count;
            IList<string> parameters = new List<string>();
            //Creamos el scope de la nueva funcion
            Scope = new Scope(scope);

            //Chequeamos los parametros...
            foreach (var field in Fields) {
                bool errorInField = false;
                //Comprobar que el tipo exista
                if (!scope.ExistsType(field.TypeId)) {
                    errors.Add(new UndefinedTypeError(Line, Column, field.TypeId));
                    errorInField = true;
                }
                //Si existe un parametro con ese mismo nombre
                if (parameters.Contains(field.Id))
                {
                    errors.Add(new DuplicateParameterError(Line, Column, field.Id));
                    errorInField = true;
                }
                else {
                    parameters.Add(field.Id);
                }

                //Anadimos este parametro al scope de la funcion
                if (!errorInField) {
                    Scope.Add(field.Id, scope.GetType(field.TypeId));
                }
            }

            //Si me especificaron un tipo y este no existe
            if (Type != null && !scope.ExistsType(Type)) {
                errors.Add(new UndefinedTypeError(Line, Column, Type));
            }

            //Si hubo errores en los parametros no seguimos o en la definicion explicita del tipo de la funcion...
            if (errorsCount != errors.Count) {
                return;
            }

            //Si estamos aqui es porque no hubo ningun error anteriormente

            //OJO: No chequeamos la semantica del cuerpo de la funcion. Lo haremos en una segunda pasada

            //Si no hubo ningun problema...
            if (errorsCount == errors.Count) {
                Callable = new Callable(Name, Fields, Type);
                scope.AddCallable(Callable);
            }
        }

        /// <summary>
        /// Chequea semanticamente el cuerpo de la funcion
        /// Ademas, comprueba que el tipo de retorno especificado coincide con el del cuerpo de la funcion
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="errors"></param>
        public void CheckBodySemantic(Scope scope, IList<Error> errors) {
            int errorsCount = errors.Count;
            Body.CheckSemantic(Scope, errors);

            //Si ocurrio algun error...
            if (errorsCount != errors.Count) {
                return;
            }

            //Comprobamos que el tipo de retorno especificado coincida con el del cuerpo de la funcion
            if (Type != null)
            {
                var type = scope.GetType(Type);

                //Si la expresion no retorna ningun valor
                if (!Body.ReturnsValue())
                {
                    errors.Add(new NonValueAssignmentError(Line, Column, Name));
                }
                //Comprobamos que el tipo del cuerpo de la funcion sea igual al especificado
                else if (type != Body.ReturnType)
                {
                    //Si no pasa que el tipo es 'nil' y puede ser asignado (es decir, si el tipo no es 'nil', o si el tipo es 'nil' y no puede ser asignado
                    if (!(Body.ReturnType is NilType && NilType.CanBeAssignedTo(type))) {
                        errors.Add(new UnexpectedTypeError(Line, Column, type, Body.ReturnType));
                    }
                }
                //TODO: Es posible retornar Nil aqui?
            }
        }

        public Scope Scope { get; set; }

        public FieldBuilder ParentInstance {
            get;
            set;
        }
    }
}
