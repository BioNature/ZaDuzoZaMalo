namespace GUIgra
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
            this.components = new System.ComponentModel.Container();
            this.NowaGra = new System.Windows.Forms.Button();
            this.GroupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.LiczbaProb = new System.Windows.Forms.Label();
            this.WylosowanaLiczba = new System.Windows.Forms.Label();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.Komentarz = new System.Windows.Forms.Label();
            this.Zgadywana = new System.Windows.Forms.TextBox();
            this.Pauza = new System.Windows.Forms.Button();
            this.Wylosuj = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.TextBox();
            this.Od = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Historia = new System.Windows.Forms.Button();
            this.Informacje = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Czasomierz = new System.Windows.Forms.Label();
            this.GroupBoxLosuj.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(12, 12);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "Nowa Gra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // GroupBoxLosuj
            // 
            this.GroupBoxLosuj.Controls.Add(this.LiczbaProb);
            this.GroupBoxLosuj.Controls.Add(this.WylosowanaLiczba);
            this.GroupBoxLosuj.Controls.Add(this.Sprawdz);
            this.GroupBoxLosuj.Controls.Add(this.Komentarz);
            this.GroupBoxLosuj.Controls.Add(this.Zgadywana);
            this.GroupBoxLosuj.Controls.Add(this.Pauza);
            this.GroupBoxLosuj.Controls.Add(this.Wylosuj);
            this.GroupBoxLosuj.Controls.Add(this.Do);
            this.GroupBoxLosuj.Controls.Add(this.Od);
            this.GroupBoxLosuj.Controls.Add(this.label2);
            this.GroupBoxLosuj.Controls.Add(this.label1);
            this.GroupBoxLosuj.Location = new System.Drawing.Point(12, 42);
            this.GroupBoxLosuj.Name = "GroupBoxLosuj";
            this.GroupBoxLosuj.Size = new System.Drawing.Size(440, 275);
            this.GroupBoxLosuj.TabIndex = 1;
            this.GroupBoxLosuj.TabStop = false;
            this.GroupBoxLosuj.Text = "Losowanie";
            this.GroupBoxLosuj.Visible = false;
            // 
            // LiczbaProb
            // 
            this.LiczbaProb.AutoSize = true;
            this.LiczbaProb.Location = new System.Drawing.Point(12, 251);
            this.LiczbaProb.Name = "LiczbaProb";
            this.LiczbaProb.Size = new System.Drawing.Size(63, 13);
            this.LiczbaProb.TabIndex = 8;
            this.LiczbaProb.Text = "Liczba Prób";
            // 
            // WylosowanaLiczba
            // 
            this.WylosowanaLiczba.AutoSize = true;
            this.WylosowanaLiczba.Location = new System.Drawing.Point(6, 185);
            this.WylosowanaLiczba.Name = "WylosowanaLiczba";
            this.WylosowanaLiczba.Size = new System.Drawing.Size(102, 13);
            this.WylosowanaLiczba.TabIndex = 7;
            this.WylosowanaLiczba.Text = "Wylosowana Liczba";
            // 
            // Sprawdz
            // 
            this.Sprawdz.Location = new System.Drawing.Point(346, 175);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(75, 23);
            this.Sprawdz.TabIndex = 2;
            this.Sprawdz.Text = "Sprawdź";
            this.Sprawdz.UseVisualStyleBackColor = true;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // Komentarz
            // 
            this.Komentarz.AutoSize = true;
            this.Komentarz.Location = new System.Drawing.Point(7, 136);
            this.Komentarz.Name = "Komentarz";
            this.Komentarz.Size = new System.Drawing.Size(57, 13);
            this.Komentarz.TabIndex = 6;
            this.Komentarz.Text = "Komentarz";
            // 
            // Zgadywana
            // 
            this.Zgadywana.Location = new System.Drawing.Point(228, 178);
            this.Zgadywana.Name = "Zgadywana";
            this.Zgadywana.Size = new System.Drawing.Size(100, 20);
            this.Zgadywana.TabIndex = 5;
            this.Zgadywana.Text = "Zgadywana";
            this.Zgadywana.TextChanged += new System.EventHandler(this.Zgadywana_MouseClick);
            // 
            // Pauza
            // 
            this.Pauza.Location = new System.Drawing.Point(346, 246);
            this.Pauza.Name = "Pauza";
            this.Pauza.Size = new System.Drawing.Size(75, 23);
            this.Pauza.TabIndex = 2;
            this.Pauza.Text = "Pauza";
            this.Pauza.UseVisualStyleBackColor = true;
            this.Pauza.Click += new System.EventHandler(this.Pauza_Click);
            // 
            // Wylosuj
            // 
            this.Wylosuj.Location = new System.Drawing.Point(228, 49);
            this.Wylosuj.Name = "Wylosuj";
            this.Wylosuj.Size = new System.Drawing.Size(75, 23);
            this.Wylosuj.TabIndex = 4;
            this.Wylosuj.Text = "Wylosuj";
            this.Wylosuj.UseVisualStyleBackColor = true;
            this.Wylosuj.Click += new System.EventHandler(this.Wylosuj_Click);
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(82, 64);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(100, 20);
            this.Do.TabIndex = 3;
            this.Do.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Do_MouseClick);
            // 
            // Od
            // 
            this.Od.Location = new System.Drawing.Point(82, 32);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(100, 20);
            this.Od.TabIndex = 2;
            this.Od.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Od_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zakres do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakres od";
            // 
            // Historia
            // 
            this.Historia.Location = new System.Drawing.Point(377, 607);
            this.Historia.Name = "Historia";
            this.Historia.Size = new System.Drawing.Size(75, 23);
            this.Historia.TabIndex = 3;
            this.Historia.Text = "Historia";
            this.Historia.UseVisualStyleBackColor = true;
            this.Historia.Click += new System.EventHandler(this.Historia_Click);
            // 
            // Informacje
            // 
            this.Informacje.Location = new System.Drawing.Point(12, 607);
            this.Informacje.Name = "Informacje";
            this.Informacje.Size = new System.Drawing.Size(75, 23);
            this.Informacje.TabIndex = 4;
            this.Informacje.Text = "Informacje";
            this.Informacje.UseVisualStyleBackColor = true;
            this.Informacje.Click += new System.EventHandler(this.Informacje_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Czasomierz
            // 
            this.Czasomierz.AutoSize = true;
            this.Czasomierz.Location = new System.Drawing.Point(21, 341);
            this.Czasomierz.Name = "Czasomierz";
            this.Czasomierz.Size = new System.Drawing.Size(60, 13);
            this.Czasomierz.TabIndex = 5;
            this.Czasomierz.Text = "Czasomierz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 642);
            this.Controls.Add(this.Czasomierz);
            this.Controls.Add(this.Informacje);
            this.Controls.Add(this.Historia);
            this.Controls.Add(this.GroupBoxLosuj);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBoxLosuj.ResumeLayout(false);
            this.GroupBoxLosuj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox GroupBoxLosuj;
        private System.Windows.Forms.Button Wylosuj;
        private System.Windows.Forms.TextBox Do;
        private System.Windows.Forms.TextBox Od;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Komentarz;
        private System.Windows.Forms.TextBox Zgadywana;
        private System.Windows.Forms.Button Pauza;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Button Historia;
        private System.Windows.Forms.Button Informacje;
        private System.Windows.Forms.Label LiczbaProb;
        private System.Windows.Forms.Label WylosowanaLiczba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Czasomierz;
    }
}

