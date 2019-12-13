using System;
using NUnit.Framework;

namespace SqlGenerator.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var t1 = new Table("table_1", "id");
            var c1 = new Column("name", t1);
            var c2 = new Column("city", t1);

            var g = new Generator();
            g.Columns.Add(c1);
            g.Columns.Add(c2);
            g.Tables.Add(t1);
            
            Assert.AreEqual(
                "SELECT table_1.name, table_1.city FROM table_1",
                g.ToString()
                );
        }
    }
}