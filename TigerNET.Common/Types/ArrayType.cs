namespace TigerNET.Common.Types {
    public class ArrayType : TigerType {

        public ArrayType(string name, TigerType elementsType) : base(name) {
            ElementsType = elementsType;
            //TODO: Lanzar excepcion aqui si me crean un array de un tipo invalido (eg. void)?
        }

        public TigerType ElementsType { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this)) {
                return true;
            }
            if (obj.GetType() != typeof(ArrayType)) {
                return false;
            }
            var arrayType = (ArrayType) obj;
            if (arrayType.Name != Name) {
                return false;
            }
            return arrayType.ElementsType == ElementsType;
        }
    }
}