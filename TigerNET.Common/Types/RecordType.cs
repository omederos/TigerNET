using System.Collections.Generic;
using System.Linq;

namespace TigerNET.Common.Types {

    public class Fields : Dictionary<string, TigerType> {
        public override bool Equals(object obj)
        {
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
        public RecordType(string name, Fields fields) : base(name) {
            Fields = fields;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(RecordType)) {
                return false;
            }
            var recordType = (RecordType) obj;

            if (recordType.Name != Name) {
                return false;
            }
            return Fields.Equals(recordType.Fields);
        }

        protected Fields Fields { get; set; }
    }
}