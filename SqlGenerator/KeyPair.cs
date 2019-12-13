using System;

namespace SqlGenerator
{
    public class KeyPair
    {
        public KeyPair(Table table, Table foreignTable, string foreignKey)
        {
            Table = table ?? throw new ArgumentNullException(nameof(table));
            ForeignTable = foreignTable ?? throw new ArgumentNullException(nameof(foreignTable));
            ForeignKey = foreignKey ?? throw new ArgumentNullException(nameof(foreignKey));
        }

        public Table Table { get; }
        public Table ForeignTable { get; }
        public string ForeignKey { get; }
    }
}