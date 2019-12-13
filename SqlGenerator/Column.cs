using System;

namespace SqlGenerator
{
    public class Column
    {
        public Column(string name, Table table)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Table = table ?? throw new ArgumentNullException(nameof(table));
        }

        public string Name { get; }
        public Table Table { get; }


        public override string ToString()
        {
            return $"{Table}.{Name}";
        }
    }
}