using System;
using System.Collections.Generic;
using System.Linq;
using TigerNET.AST;

namespace TigerNET.Common.Types {

    public class Fields : Dictionary<string, TigerType> {
        public Fields(IDictionary<string, TigerType> fields) : base(fields) {}
        public Fields() {}
        
        public override bool Equals(object obj)
        {
            //Si son la misma referencia
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            if (!(obj is IDictionary<string, TigerType>)) {
                return false;
            }
            var fields = (IDictionary<string, TigerType>) obj;
            if (fields.Count != Count) {
                return false;
            }

            var f1 = this.ToList();
            var f2 = fields.ToList();


            return !f1.Where((t, i) => t.Key != f2[i].Key || t.Value != f2[i].Value).Any();
        }
    }

    public class RecordType : TigerType
    {
        public RecordType(string name, Fields fields) : base(name, Guid.NewGuid()) {
            Fields = fields;
        }

//        public override bool Equals(object obj)
//        {
//            if (ReferenceEquals(obj, this)) {
//                return true;
//            }
//
//            if (obj == null) {
//                return false;
//            }
//
//            if (obj.GetType() != typeof(RecordType)) {
//                return false;
//            }
//            var recordType = (RecordType) obj;
//
//            if (recordType.Name != Name) {
//                return false;
//            }
//            return Fields.Equals(recordType.Fields);
//        }

        public Fields Fields { get; set; }

        public override string ToString() {
            return string.Format("[Record] ({0}) ({1})", Name, Id);
        }
        
    }
}