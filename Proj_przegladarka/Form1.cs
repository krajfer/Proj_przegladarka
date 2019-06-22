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

       public String strona;


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
        //po nacisnieciu enter w textbox adres przechodzi do wpisanej strony
        public void zatwierdz(object sender, KeyEventArgs e)
        {
            strona = sender.ToString();
            Historia historia = new Historia();

            if (e.KeyCode == Keys.Enter)
               {
                    webBrowser1.Navigate(Adres.Text);
            

            }
            if (e.KeyCode == Keys.Enter)
            {
                SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Hist (Url) VALUES (@Url)";
                cmd.Parameters.AddWithValue("@Url",Adres.Text);
                cmd.ExecuteNonQuery();

            }

        }
        //cofa do poprzedniej strony
        private void wstecz_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        //przechodzi do nastepnej
        private void nastepna_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        //odswierza strone
        private void odswierz_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
        //przechodzi do strony domowej
        private void domowa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Adres.Text = webBrowser1.Url.ToString();
           
        }

        private void Adres_TextChanged(object sender, EventArgs e)
        {
           
        }

        //pokazuje formularz historii
        private void button1_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            historia.Show();
           
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
          

        }
        //qwyszukuje w google tekst z textboxa wyszukaj
        private void Wyszukiwarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate("http://google.com/search?q=" + Wyszukiwarka.Text);
                SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\nowez.db;");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Hist (Url) VALUES (@Url)";
                cmd.Parameters.AddWithValue("@Url", "http://google.com/search?q=" + Wyszukiwarka.Text);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
