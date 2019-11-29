using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator
{
    internal static class SqlGenerator
    {
        public static string From(Konfiguracja konfiguracja)
        {
            var columns = new List<string>();
            var tables = new List<string>();
            var joins = new List<string>();

            foreach (var table in konfiguracja.Columns)
            {
                foreach (var column in table.Value)
                {
                    if(column.Value != null)
                        columns.Add($"{column.Value}({table.Key}.{column.Key})");
                    else
                        columns.Add($"{table.Key}.{column.Key}");
                }

                if (!tables.Contains(table.Key))
                    tables.Add(table.Key);
            }

            foreach (var j in konfiguracja.Joins)
            {
                joins.Add(
                    $"{j.Key.Key}.{j.Key.Value} = {j.Value.Key}.{j.Value.Value}"
                );
            }

            var sql = "SELECT "
                      + string.Join(", ", columns)
                      + " FROM "
                      + string.Join(", ", tables);


            if(joins.Count != 0)
                sql += " WHERE " 
                   + string.Join(", ", joins);

            return sql;
        }
    }
}