using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Generator
{
    public partial class FormGenerator : Form
    {
        protected SqlConnection connection = new SqlConnection();

        public string Tabela { get; set; }

        public Konfiguracja Config { get; set; }


        public FormGenerator()
        {
            InitializeComponent();
            Config = new Konfiguracja();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.ConnectionString = ProcessConnectionString(connectionStringTextBox.Text);
                    connection.Open();


                    DataTable schema = connection.GetSchema("Tables");
                    listBoxTabele.Items.Clear();
                    foreach (DataRow row in schema.Rows)
                    {
                        if(row[2].ToString() != "sysdiagrams")
                            listBoxTabele.Items.Add(row[2].ToString());
                    }

                    Config.ConnectionString = ProcessConnectionString(connectionStringTextBox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: "+exception.Message);
                    return;
                }
            } else {
                connection.Close();
                listBoxTabele.Items.Clear();
                listBoxKolumny.Items.Clear();
                listBoxWybrane.Items.Clear();
                Tabela = null;
            }

            if (connection.State == ConnectionState.Open)
            {
                statusLabel.Text = "Połączono";
                toolStripButton1.Text = "Rozłącz";
                connectionStringTextBox.Enabled = false;
                listBoxKolumny.Enabled = true;
                listBoxTabele.Enabled = true;
                listBoxWybrane.Enabled = true;
            } else
            {
                statusLabel.Text = "-";
                toolStripButton1.Text = "Połącz";
                connectionStringTextBox.Enabled = true;
                listBoxKolumny.Enabled = false;
                listBoxTabele.Enabled = false;
                listBoxWybrane.Enabled = false;
                ExportBTN.Enabled = false;
            }
        }

        private static string ProcessConnectionString(string connectionString)
        {
            var prefix = "\x08\x08\x0C\x16";
            var suffix = "\x68\x67\x66\x65";

            for (int ZBOKN = 0, homvG = 0; ZBOKN < 4; ZBOKN++)
            {
                homvG = prefix[ZBOKN];
                homvG = ~homvG;
                homvG ^= 0x80;
                prefix = prefix.Substring(0, ZBOKN) + (char)(homvG & 0xFF) + prefix.Substring(ZBOKN + 1);
            }

            for (int cUFZP = 0, BWJNz = 0; cUFZP < 4; cUFZP++)
            {
                BWJNz = suffix[cUFZP];
                BWJNz += cUFZP;
                BWJNz += 0xC9;
                BWJNz += cUFZP;
                suffix = suffix.Substring(0, cUFZP) + (char)(BWJNz & 0xFF) + suffix.Substring(cUFZP + 1);
            }

            return connectionString.Replace("<*********>", prefix+suffix);
        }

        private void listBoxTabele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTabele_DoubleClick(object sender, EventArgs e)
        {
            string[] restrictionsColumns = new string[4];
            restrictionsColumns[2] = Tabela = (string)listBoxTabele.Text;
            DataTable schemaColumns = connection.GetSchema("Columns", restrictionsColumns);

            listBoxKolumny.Items.Clear();
            foreach (System.Data.DataRow rowColumn in schemaColumns.Rows)
            {
                listBoxKolumny.Items.Add(rowColumn[3].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filebox = new SaveFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                DefaultExt = ".db.exe",
                Filter = "Pliki generatora|*.db.exe",
                OverwritePrompt = true,
                SupportMultiDottedExtensions = true,
            };

            if (filebox.ShowDialog() != DialogResult.OK)
                return;

            Exporter.MakeExe(
                System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, 
                filebox.FileName, 
                Config
            );

            MessageBox.Show("Plik EXE został wygenerowany!");
        }

        private void connectionStringTextBox_Click(object sender, EventArgs e)
        {

        }

        private void listBoxKolumny_DoubleClick(object sender, EventArgs e)
        {
            var zaznaczony = (string) listBoxKolumny.SelectedItem;

            if (zaznaczony == null)
                return;

            if(!Config.Columns.ContainsKey(Tabela))
                Config.Columns.Add(Tabela, new Dictionary<string, string>());

            if(!Config.Columns[Tabela].ContainsKey(zaznaczony))
                Config.Columns[Tabela].Add(zaznaczony, null);

            ReloadSelectedList();
        }

        private void ReloadSelectedList()
        {
            listBoxWybrane.Items.Clear();

            foreach (var table in Config.Columns)
            {
                foreach (var column in table.Value)
                {
                    listBoxWybrane.Items.Add(
                        column.Value == null
                        ? $"{table.Key} -> {column.Key}"
                        : $"{table.Key} -> {column.Key} -> {column.Value}"
                    );
                }
            }

            listBoxJoin.Items.Clear();
            foreach (var j in Config.Joins)
            {
                listBoxJoin.Items.Add(
                    $"{j.Key.Key}.{j.Key.Value} = {j.Value.Key}.{j.Value.Value}"
                );
            }

            ExportBTN.Enabled = true;
        }

        private void listBoxWybrane_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var zaznaczony = (string)listBoxWybrane.SelectedItem;

            if (zaznaczony == null)
                return;

            WybranaOpcja = zaznaczony.Split(new string[] { " -> " }, StringSplitOptions.None);

            agregujToolStripMenuItem.Checked = Config.Columns[WybranaOpcja[0]][WybranaOpcja[1]] != null;
            contextMenuStrip1.Show(listBoxWybrane, e.X, e.Y);
        }

        public string[] WybranaOpcja { get; set; }

        private void listBoxKolumny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxWybrane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxWybrane_MouseClick(object sender, EventArgs e)
        {
        }

        private void listBoxWybrane_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
        }

        private void agregujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Config.Columns[WybranaOpcja[0]][WybranaOpcja[1]] == null)
                Config.Columns[WybranaOpcja[0]][WybranaOpcja[1]] = "sum";
            else
                Config.Columns[WybranaOpcja[0]][WybranaOpcja[1]] = null;

            ReloadSelectedList();
        }

        private void ustawKluczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ForeginKeyDialog(Config, WybranaOpcja[0], WybranaOpcja[1]);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReloadSelectedList();
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.Columns[WybranaOpcja[0]].Remove(WybranaOpcja[1]);
            if (Config.Columns[WybranaOpcja[0]].Count == 0)
                Config.Columns.Remove(WybranaOpcja[0]);

            ReloadSelectedList();
        }
    }
}
