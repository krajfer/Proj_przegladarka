namespace Proj_przegladarka
{
    partial class Karty
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Adres = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.domowa = new System.Windows.Forms.Button();
            this.odswierz = new System.Windows.Forms.Button();
            this.nastepna = new System.Windows.Forms.Button();
            this.wstecz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Adres);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.domowa);
            this.panel2.Controls.Add(this.odswierz);
            this.panel2.Controls.Add(this.nastepna);
            this.panel2.Controls.Add(this.wstecz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 0;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(206, 9);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(532, 20);
            this.Adres.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(744, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 41);
            this.panel3.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(827, 416);
            this.webBrowser1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Proj_przegladarka.Properties.Resources.opcje1;
            this.button1.Location = new System.Drawing.Point(22, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // domowa
            // 
            this.domowa.Image = global::Proj_przegladarka.Properties.Resources.home1;
            this.domowa.Location = new System.Drawing.Point(147, 0);
            this.domowa.Name = "domowa";
            this.domowa.Size = new System.Drawing.Size(40, 41);
            this.domowa.TabIndex = 3;
            this.domowa.UseVisualStyleBackColor = true;
            // 
            // odswierz
            // 
            this.odswierz.Image = global::Proj_przegladarka.Properties.Resources.odswierz1;
            this.odswierz.Location = new System.Drawing.Point(101, 0);
            this.odswierz.Name = "odswierz";
            this.odswierz.Size = new System.Drawing.Size(40, 41);
            this.odswierz.TabIndex = 2;
            this.odswierz.UseVisualStyleBackColor = true;
            // 
            // nastepna
            // 
            this.nastepna.Image = global::Proj_przegladarka.Properties.Resources.cofnij_wstecz1;
            this.nastepna.Location = new System.Drawing.Point(55, 0);
            this.nastepna.Name = "nastepna";
            this.nastepna.Size = new System.Drawing.Size(40, 41);
            this.nastepna.TabIndex = 1;
            this.nastepna.UseVisualStyleBackColor = true;
            // 
            // wstecz
            // 
            this.wstecz.Image = global::Proj_przegladarka.Properties.Resources.wstecz11;
            this.wstecz.Location = new System.Drawing.Point(9, 0);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(40, 41);
            this.wstecz.TabIndex = 0;
            this.wstecz.UseVisualStyleBackColor = true;
            // 
            // Karty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Karty";
            this.Size = new System.Drawing.Size(827, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button domowa;
        private System.Windows.Forms.Button odswierz;
        private System.Windows.Forms.Button nastepna;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}
