using System;
using System.Collections.Generic;

namespace Generator
{
    [Serializable]
    public class Konfiguracja
    {
        public string ConnectionString { get; set; }
        public string Table { get; set; }
        public List<string> Columns { get; set; }
    }
}