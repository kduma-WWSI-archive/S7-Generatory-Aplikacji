using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SqlGenerator
{
    public class Generator
    {
        public Collection<Table> Tables = new Collection<Table>();
        public Collection<Column> Columns = new Collection<Column>();
        public Collection<KeyPair> KeyPairs = new Collection<KeyPair>();

        public override string ToString()
        {
            var col = string.Join(", ", Columns.Select((column => column.ToString())).ToArray());
            var tab = Tables.First();
                
            
            return $"SELECT {col} FROM {tab}";
        }
    }
}