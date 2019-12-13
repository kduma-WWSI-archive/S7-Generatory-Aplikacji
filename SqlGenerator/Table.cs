using System;

namespace SqlGenerator
{
    public class Table
    {
        public Table(string name, string primaryKey)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            PrimaryKey = primaryKey ?? throw new ArgumentNullException(nameof(primaryKey));
        }

        public string Name { get; }
        public string PrimaryKey { get; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}