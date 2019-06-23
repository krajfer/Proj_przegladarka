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

       
       

        public Historia()
        {
            InitializeComponent();

         
        }
        /// <summary>
        /// Funkcja po wcisnieciu przycisku bwyczysc 
        /// łączy się z bazą w celu usunięcia z niej zawartosci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwyczysc_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Hist";
            cmd.ExecuteNonQuery();
            


        }
       

        /// <summary>
        /// Przy otwieraniu okna Historii Funkcja załadowuję aktualną historie z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        /// <summary>
        /// Wyswietla Formularz Zapisanych stron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Zapisane_strony zapisane_Strony = new Zapisane_strony();
            zapisane_Strony.Show();
        }

      
        /// <summary>
        /// zmienia kolor Paska zadań na wybrany przez użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zmieńKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }
    }
}
