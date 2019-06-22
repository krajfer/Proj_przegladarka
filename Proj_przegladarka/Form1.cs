using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Proj_przegladarka
{
    public partial class Form1 : Form
    {

       

        /// <summary>
        /// Funkcja z Pakietu EasyTabs słuzy do otwierania nowych kart
        /// </summary>
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        /// <summary>
        /// po nacisnieciu enter w textbox adres przechodzi do wpisanej strony 
        /// </summary>
        public void zatwierdz(object sender, KeyEventArgs e)
        {
           
         

            if (e.KeyCode == Keys.Enter)
               {
                    webBrowser1.Navigate(Adres.Text);
              
            }
            

        } 

        /// cofa do poprzedniej strony
        private void wstecz_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        /// przechodzi do nastepnej
        private void nastepna_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        /// odswierza strone
        private void odswierz_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        ///przechodzi do strony domowej
        private void domowa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        /// <summary>
        /// przypisuje textboxowi wartosc aktualnej strony oraz zapisuje ją w Historii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Adres.Text = webBrowser1.Url.ToString();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO Hist (Url) VALUES (@Url)";
            cmd.Parameters.AddWithValue("@Url", webBrowser1.Url.ToString());
            cmd.ExecuteNonQuery();
        }

        private void Adres_TextChanged(object sender, EventArgs e)
        {
           
        }

        /// pokazuje formularz historii
        private void button1_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            historia.Show();
           
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
          

        }
        /// <summary>
        /// wyszukuje w google tekst z textboxa wyszukaj 
        /// </summary>
        private void Wyszukiwarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate("http://google.com/search?q=" + Wyszukiwarka.Text);
              
            }
        }
        /// <summary>
        /// Zapisuje wybrana strone po kliknieciu przycisku
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO Zapis (Url) VALUES (@Url)";
            cmd.Parameters.AddWithValue("@Url", Adres.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
