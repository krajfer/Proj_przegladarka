using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_przegladarka
{
    public partial class Zapisane_strony : Form
    {
        public Zapisane_strony()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Wyswietla w datagrid zawartosc bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zapisane_strony_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select * from Zapis";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable Zap = new DataTable();
                Zap.Load(sdr);
                sdr.Close();
                connection.Close();
                dataGridView1.DataSource = Zap;
            }
        }
        /// <summary>
        /// Usuwa z bazy wybrane elementy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwyczysc_Click(object sender, EventArgs e)
        {
            int iwiersz = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(iwiersz);
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Zapis where id="+iwiersz;
            cmd.ExecuteNonQuery();
            
        }

        /// <summary>
        /// zamyka okno przeglądarki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// zmienia kolor Paska zadań na wybrany przez użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zmieńKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }

}
