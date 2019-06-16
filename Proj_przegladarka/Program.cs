using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Proj_przegladarka
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContanier contanier = new AppContanier();

            contanier.Tabs.Add(
                new TitleBarTab(contanier)
                {
                    Content = new Form1
                    {
                        
                    }
                });
            //set initial tab first one
            contanier.SelectedTabIndex = 0;

            //Create tabs and start aplication
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(contanier);
            Application.Run(applicationContext);
        }
    }
}
