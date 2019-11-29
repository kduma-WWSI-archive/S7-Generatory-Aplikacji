using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class Aplikacja : Form
    {
        protected SqlConnection connection = new SqlConnection();
        public Aplikacja(Konfiguracja konfiguracja)
        {
            InitializeComponent();
            Konfiguracja = konfiguracja;
        }

        public Konfiguracja Konfiguracja { get; }

        private void Aplikacja_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = Konfiguracja.ConnectionString;

            connection.Open();

            //var dataAdapter = new SqlDataAdapter("SELECT " + String.Join(", ", Konfiguracja.Columns) + " FROM " + Konfiguracja.Table, connection);

            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);
            //dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = ds.Tables[0];

            //label1.Text = Konfiguracja.ConnectionString;
            //Text += label2.Text = Konfiguracja.Table;
            //label3.Text = String.Join(", ", Konfiguracja.Columns); 
        }
    }
}
