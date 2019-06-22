using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace Proj_przegladarka
{
    public partial class Historia : Form
    {

        List<nowezzz> historie = new List<nowezzz>();
        Form1 zmienna = new Form1();

        public Historia()
        {
            InitializeComponent();

            LoadhistoryList();
        }

        private void bwyczysc_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Hist";
            cmd.ExecuteNonQuery();
            LoadhistoryList();


        }

        private void Historia_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select * from Hist";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable Hist = new DataTable();
                Hist.Load(sdr);
                sdr.Close();
                connection.Close();
                dataGridView1.DataSource = Hist;
            }
        }

        public void zapisz()
        {
          

        }

        public void LoadhistoryList()
        {
            //historie = SqlDataAcces.LoadHist();

                WirdeUpHistoryList();
        }

        public void WirdeUpHistoryList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = historie;
            dataGridView1.DataSource = "Url";
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadhistoryList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LoadhistoryList();
        }
    }
}
