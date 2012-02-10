namespace TigerNET.AST.Types {
    public class ArrayType : TigerType {

        public ArrayType(string name, TigerType elementsType) : base(name) {
            ElementsType = elementsType;
            //TODO: Lanzar excepcion aqui si me crean un array de un tipo invalido (eg. void)?
        }

        public TigerType ElementsType { get; set; }
    }
}