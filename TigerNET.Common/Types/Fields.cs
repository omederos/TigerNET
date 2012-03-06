using System.Collections.Generic;
using System.Linq;

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
}