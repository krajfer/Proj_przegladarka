namespace Proj_przegladarka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.domowa = new System.Windows.Forms.Button();
            this.odswierz = new System.Windows.Forms.Button();
            this.nastepna = new System.Windows.Forms.Button();
            this.wstecz = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 411);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(726, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 43);
            this.panel4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::Proj_przegladarka.Properties.Resources.opcje1;
            this.button1.Location = new System.Drawing.Point(34, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(3, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(517, 20);
            this.Adres.TabIndex = 1;
            this.Adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zatwierdz);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 43);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.domowa);
            this.panel6.Controls.Add(this.odswierz);
            this.panel6.Controls.Add(this.nastepna);
            this.panel6.Controls.Add(this.wstecz);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 43);
            this.panel6.TabIndex = 0;
            // 
            // domowa
            // 
            this.domowa.Image = global::Proj_przegladarka.Properties.Resources.home1;
            this.domowa.Location = new System.Drawing.Point(147, 0);
            this.domowa.Name = "domowa";
            this.domowa.Size = new System.Drawing.Size(40, 41);
            this.domowa.TabIndex = 3;
            this.domowa.UseVisualStyleBackColor = true;
            this.domowa.Click += new System.EventHandler(this.domowa_Click);
            // 
            // odswierz
            // 
            this.odswierz.Image = global::Proj_przegladarka.Properties.Resources.odswierz1;
            this.odswierz.Location = new System.Drawing.Point(101, 0);
            this.odswierz.Name = "odswierz";
            this.odswierz.Size = new System.Drawing.Size(40, 41);
            this.odswierz.TabIndex = 2;
            this.odswierz.UseVisualStyleBackColor = true;
            this.odswierz.Click += new System.EventHandler(this.odswierz_Click);
            // 
            // nastepna
            // 
            this.nastepna.Image = global::Proj_przegladarka.Properties.Resources.cofnij_wstecz1;
            this.nastepna.Location = new System.Drawing.Point(55, 0);
            this.nastepna.Name = "nastepna";
            this.nastepna.Size = new System.Drawing.Size(40, 41);
            this.nastepna.TabIndex = 1;
            this.nastepna.UseVisualStyleBackColor = true;
            this.nastepna.Click += new System.EventHandler(this.nastepna_Click);
            // 
            // wstecz
            // 
            this.wstecz.Image = global::Proj_przegladarka.Properties.Resources.wstecz11;
            this.wstecz.Location = new System.Drawing.Point(9, 0);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(40, 41);
            this.wstecz.TabIndex = 0;
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.wstecz_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Adres);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(200, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(526, 43);
            this.panel7.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(823, 411);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Przegladarka";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button domowa;
        private System.Windows.Forms.Button odswierz;
        private System.Windows.Forms.Button nastepna;
        private System.Windows.Forms.Button wstecz;
    }
}

