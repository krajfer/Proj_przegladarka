using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_przegladarka
{
    public partial class Karty : UserControl
    {
        public Karty()
        {
            InitializeComponent();
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
            webBrowser1.Refresh();
        }

        private void domowa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void Adres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(Adres.Text);
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Adres.Text = webBrowser1.Url.ToString();
            (Parent as TabPage).Text= webBrowser1.Url.ToString(); 
        }
    }
}
