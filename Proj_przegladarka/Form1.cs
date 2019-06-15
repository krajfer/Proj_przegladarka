using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_przegladarka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wcisniecie(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabdodaj)
            {
                Karty karta = new Karty();
                TabPage page = new TabPage();
                karta.Dock = DockStyle.Fill;

                page.Controls.Add(karta);
                tabControl1.Controls.Add(page);

                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                tabControl1.TabPages.Add(tabdodaj);

                tabControl1.SelectedIndex = tabControl1.TabCount - 2;
            }

        }
    }
}
