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
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Wyszukiwarka = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Adres = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.domowa = new System.Windows.Forms.Button();
            this.odswierz = new System.Windows.Forms.Button();
            this.nastepna = new System.Windows.Forms.Button();
            this.wstecz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 463);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1229, 420);
            this.panel3.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1229, 420);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1229, 43);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(200, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(932, 43);
            this.panel7.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.Wyszukiwarka);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(541, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(391, 43);
            this.panel9.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukiwarka";
            // 
            // Wyszukiwarka
            // 
            this.Wyszukiwarka.Location = new System.Drawing.Point(90, 11);
            this.Wyszukiwarka.Name = "Wyszukiwarka";
            this.Wyszukiwarka.Size = new System.Drawing.Size(295, 20);
            this.Wyszukiwarka.TabIndex = 0;
            this.Wyszukiwarka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wyszukiwarka_KeyDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Adres);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(932, 43);
            this.panel8.TabIndex = 0;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(3, 11);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(517, 20);
            this.Adres.TabIndex = 1;
            this.Adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zatwierdz);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1132, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 43);
            this.panel4.TabIndex = 2;
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
            // button1
            // 
            this.button1.Image = global::Proj_przegladarka.Properties.Resources.opcje1;
            this.button1.Location = new System.Drawing.Point(6, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Proj_przegladarka.Properties.Resources.zzzz;
            this.button2.Location = new System.Drawing.Point(52, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Z";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 463);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Przegladarka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button domowa;
        private System.Windows.Forms.Button odswierz;
        private System.Windows.Forms.Button nastepna;
        private System.Windows.Forms.Button wstecz;
        public System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox Wyszukiwarka;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

