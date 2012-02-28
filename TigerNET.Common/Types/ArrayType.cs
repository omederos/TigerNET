using System;

namespace TigerNET.Common.Types {
    public class ArrayType : TigerType {

        public ArrayType(string name, TigerType elementsType) : base(name, Guid.NewGuid()) {
            ElementsType = elementsType;
            //TODO: Lanzar excepcion aqui si me crean un array de un tipo invalido (eg. Null)?
        }

        public TigerType ElementsType { get; set; }

//        public override bool Equals(object obj)
//        {
//            if (ReferenceEquals(obj, this)) {
//                return true;
//            }
//
//            if (obj == null)
//            {
//                return false;
//            }
//
//            if (obj.GetType() != typeof(ArrayType)) {
//                return false;
//            }
//            var arrayType = (ArrayType) obj;
//            if (arrayType.Name != Name) {
//                return false;
//            }
//            return arrayType.ElementsType == ElementsType;
//        }
        public override string ToString() {
#if DEBUG
            return string.Format("TigerType.Array ({0}) ({1})", Name, Id);
#endif
            return string.Format("TigerType.Array ({0})", Name);
        }
    }
}