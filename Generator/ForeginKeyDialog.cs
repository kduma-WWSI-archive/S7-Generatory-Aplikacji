using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class ForeginKeyDialog : Form
    {
        public Konfiguracja Konfiguracja { get; }
        public string Table { get; }
        public string Column { get; }

        public ForeginKeyDialog(Konfiguracja konfiguracja, string table, string column)
        {
            Konfiguracja = konfiguracja;
            Table = table;
            Column = column;
            InitializeComponent();
        }

        private void ForeginKeyDialog_Load(object sender, EventArgs e)
        {
            label1.Text += $"{Table}.{Column}";

            foreach (var table in Konfiguracja.Columns)
            {
                foreach (var column in table.Value)
                {
                    if(column.Value != null || table.Key == Table && column.Key == Column)
                        continue;

                    listBox1.Items.Add($"{table.Key} -> {column.Key}");
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var zaznaczony = (string)listBox1.SelectedItem;

            if (zaznaczony == null)
                return;

            var p = zaznaczony.Split(new string[] { " -> " }, StringSplitOptions.None);

            var pair = new KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>(
                new KeyValuePair<string, string>(Table, Column),
                new KeyValuePair<string, string>(p[0], p[1])
            );

            if (!Konfiguracja.Joins.Contains(pair))
                Konfiguracja.Joins.Add(pair);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
