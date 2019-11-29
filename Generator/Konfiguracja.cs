using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Generator
{
    [DataContract]
    public class Konfiguracja
    {
        public Konfiguracja()
        {
            Columns = new Dictionary<string, Dictionary<string, string>>();
            Joins = new List<KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>>();
        }

        [DataMember]
        public string ConnectionString { get; set; }

        [DataMember]
        public Dictionary<string, Dictionary<string, string>> Columns { get; set; }

        [DataMember]
        public List<KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>> Joins { get; set; }
    }
}