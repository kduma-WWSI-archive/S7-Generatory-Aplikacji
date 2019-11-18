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


        public FormGenerator()
        {
            InitializeComponent();
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
            listBoxWybrane.Items.Clear();
            ExportBTN.Enabled = false;

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


            var name = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            if (File.Exists(filebox.FileName))
            {
                File.Delete(filebox.FileName);
            }
            File.Copy(name, filebox.FileName);

            using (StreamWriter sw = File.AppendText(filebox.FileName))
            {
                for(var i = 0; i < 20; i++)
                    sw.Write("\n");
                
                sw.WriteLine("<<<<<<<<<<<<<<<<<<<<USERDATA>>>>>>>>>>>>>>>>>>>>");
                
                sw.Flush();
                
                var formatter = new XmlSerializer(typeof(Konfiguracja));

                var konfiguracja = new Konfiguracja()
                {
                    ConnectionString = ProcessConnectionString(connectionStringTextBox.Text),
                    Table = Tabela,
                    Columns = listBoxWybrane.Items.Cast<String>().ToList()
                };
                formatter.Serialize(sw.BaseStream, konfiguracja);
            }
            


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

            listBoxWybrane.Items.Add(zaznaczony);
            listBoxKolumny.Items.Remove(zaznaczony);
            ExportBTN.Enabled = true;
        }

        private void listBoxWybrane_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var zaznaczony = (string)listBoxWybrane.SelectedItem;

            if (zaznaczony == null)
                return;

            listBoxKolumny.Items.Add(zaznaczony);
            listBoxWybrane.Items.Remove(zaznaczony);

            if(listBoxWybrane.Items.Count == 0)
                ExportBTN.Enabled = false;
        }

        private void listBoxKolumny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
