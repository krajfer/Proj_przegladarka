using System;
using EasyTabs;

namespace Proj_przegladarka
{
    public partial class AppContanier : TitleBarTabs
    {
        public AppContanier()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }


        /// <summary>
        /// Tworzy nowe karty
        /// </summary>
        /// <returns></returns>
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1

                {
                    Text = "Nowa karta"

                }
            };
        }

        private void AppContanier_Load(object sender, EventArgs e)
        {

        }
    }
}
