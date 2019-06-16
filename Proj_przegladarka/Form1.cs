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

namespace Proj_przegladarka
{
    public partial class Form1 : Form
    {
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

        private void wcisniecie(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Adres.Text)) return;
            if (Adres.Equals("about:blank")) return;
            if (!Adres.Text.StartsWith("http://") &&
                !Adres.Text.StartsWith("https://") )
            {
                Adres.Text = "http://" + Adres.Text;
            }
           
            try
            {
                webBrowser1.Navigate(new Uri(Adres.Text));
            }
            catch (System.UriFormatException)
            {
                return;
            }



        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void zatwierdz(object sender, KeyEventArgs e)
        {
           
              if (e.KeyCode == Keys.Enter)
               {
                    webBrowser1.Navigate(Adres.Text);
              }
            
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void nastepna_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void odswierz_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        private void domowa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Adres.Text = webBrowser1.Url.ToString();
           
        }
    }
}
