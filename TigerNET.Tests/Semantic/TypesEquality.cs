using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TigerNET.Common.Types;

namespace TigerNET.Tests.Semantic
{
    public class TypesEquality
    {
        [Test]
        public void TwoNullTypes() {
            StringType t1 = null;
            StringType t2 = null;

            Assert.That(t1 == t2);
        }

        [Test]
        public void StringType_Equals() {
            var t1 = StringType.Create();
            var t2 = StringType.Create();

            Assert.That(t1 == t2);
        }

        [Test]
        public void IntegerType_Equals() {
            var t1 = IntegerType.Create();
            var t2 = IntegerType.Create();

            Assert.That(t1 == t2);
        }

        [Test]
        public void RecordType_Equals()
        {
            var fields1 = new Fields {{"name", StringType.Create()}, {"lastname", StringType.Create()}};
            var fields2 = new Fields {{"name", StringType.Create()}, {"lastname", StringType.Create()}};

            var t1 = new RecordType("somerecord", fields1);
            var t2 = new RecordType("somerecord", fields2);

            Assert.That(t1 == t2);
        }

        [Test]
        public void RecordType_DifferentName()
        {
            var fields1 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };
            var fields2 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };

            var t1 = new RecordType("somerecord_", fields1);
            var t2 = new RecordType("somerecord", fields2);

            Assert.That(t1 != t2);
        }

        [Test]
        public void RecordType_DifferentFieldNames()
        {
            var fields1 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };
            var fields2 = new Fields { { "name_", StringType.Create() }, { "lastname", StringType.Create() } };

            var t1 = new RecordType("somerecord", fields1);
            var t2 = new RecordType("somerecord", fields2);

            Assert.That(t1 != t2);
        }

        [Test]
        public void RecordType_DifferentFieldTypes()
        {
            var fields1 = new Fields { { "name", IntegerType.Create() }, { "lastname", StringType.Create() } };
            var fields2 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };

            var t1 = new RecordType("somerecord", fields1);
            var t2 = new RecordType("somerecord", fields2);

            Assert.That(t1 != t2);
        }

        [Test]
        public void ArrayType_Equals()
        {
            var fields1 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };
            var fields2 = new Fields { { "name", StringType.Create() }, { "lastname", StringType.Create() } };

            var t1 = new RecordType("somerecord", fields1);
            var t2 = new RecordType("somerecord", fields2);

            var a1 = new ArrayType("somearray", t1);
            var a2 = new ArrayType("somearray", t2);

            Assert.That(a1 == a2);
        }

        [Test]
        public void ArrayType_DifferentName()
        {
            var a1 = new ArrayType("somearray_", IntegerType.Create());
            var a2 = new ArrayType("somearray", IntegerType.Create());

            Assert.That(a1 != a2);
        }

        [Test]
        public void ArrayType_DifferentElementsType()
        {
            var a1 = new ArrayType("somearray", IntegerType.Create());
            var a2 = new ArrayType("somearray", StringType.Create());

            Assert.That(a1 != a2);
        }
    }
}
