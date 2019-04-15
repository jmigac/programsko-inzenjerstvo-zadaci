namespace Lab5V2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxVrsteGrupa = new System.Windows.Forms.ComboBox();
            this.BtnDodajGrupu = new System.Windows.Forms.Button();
            this.LstGrupe = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBroj = new System.Windows.Forms.TextBox();
            this.BtnUnesiKontakt = new System.Windows.Forms.Button();
            this.LstKontakti = new System.Windows.Forms.ListBox();
            this.BtnDodjeli = new System.Windows.Forms.Button();
            this.LstSviKontaktiPoGrupama = new System.Windows.Forms.ListBox();
            this.CboxFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv grupe:";
            // 
            // TxtNazivGrupe
            // 
            this.TxtNazivGrupe.Location = new System.Drawing.Point(16, 30);
            this.TxtNazivGrupe.Name = "TxtNazivGrupe";
            this.TxtNazivGrupe.Size = new System.Drawing.Size(151, 20);
            this.TxtNazivGrupe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta grupe:";
            // 
            // CboxVrsteGrupa
            // 
            this.CboxVrsteGrupa.FormattingEnabled = true;
            this.CboxVrsteGrupa.Items.AddRange(new object[] {
            "Obitelj",
            "Prijatelji"});
            this.CboxVrsteGrupa.Location = new System.Drawing.Point(16, 74);
            this.CboxVrsteGrupa.Name = "CboxVrsteGrupa";
            this.CboxVrsteGrupa.Size = new System.Drawing.Size(151, 21);
            this.CboxVrsteGrupa.TabIndex = 3;
            // 
            // BtnDodajGrupu
            // 
            this.BtnDodajGrupu.Location = new System.Drawing.Point(16, 102);
            this.BtnDodajGrupu.Name = "BtnDodajGrupu";
            this.BtnDodajGrupu.Size = new System.Drawing.Size(151, 23);
            this.BtnDodajGrupu.TabIndex = 4;
            this.BtnDodajGrupu.Text = "Dodaj";
            this.BtnDodajGrupu.UseVisualStyleBackColor = true;
            this.BtnDodajGrupu.Click += new System.EventHandler(this.BtnDodajGrupu_Click);
            // 
            // LstGrupe
            // 
            this.LstGrupe.FormattingEnabled = true;
            this.LstGrupe.Location = new System.Drawing.Point(16, 132);
            this.LstGrupe.Name = "LstGrupe";
            this.LstGrupe.Size = new System.Drawing.Size(151, 173);
            this.LstGrupe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ime kontakta:";
            // 
            // TxtIme
            // 
            this.TxtIme.Location = new System.Drawing.Point(196, 30);
            this.TxtIme.Name = "TxtIme";
            this.TxtIme.Size = new System.Drawing.Size(144, 20);
            this.TxtIme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj kontakta:";
            // 
            // TxtBroj
            // 
            this.TxtBroj.Location = new System.Drawing.Point(196, 75);
            this.TxtBroj.Name = "TxtBroj";
            this.TxtBroj.Size = new System.Drawing.Size(144, 20);
            this.TxtBroj.TabIndex = 9;
            // 
            // BtnUnesiKontakt
            // 
            this.BtnUnesiKontakt.Location = new System.Drawing.Point(196, 102);
            this.BtnUnesiKontakt.Name = "BtnUnesiKontakt";
            this.BtnUnesiKontakt.Size = new System.Drawing.Size(144, 23);
            this.BtnUnesiKontakt.TabIndex = 10;
            this.BtnUnesiKontakt.Text = "Unesi";
            this.BtnUnesiKontakt.UseVisualStyleBackColor = true;
            this.BtnUnesiKontakt.Click += new System.EventHandler(this.BtnUnesiKontakt_Click);
            // 
            // LstKontakti
            // 
            this.LstKontakti.FormattingEnabled = true;
            this.LstKontakti.Location = new System.Drawing.Point(196, 132);
            this.LstKontakti.Name = "LstKontakti";
            this.LstKontakti.Size = new System.Drawing.Size(144, 173);
            this.LstKontakti.TabIndex = 11;
            // 
            // BtnDodjeli
            // 
            this.BtnDodjeli.Location = new System.Drawing.Point(16, 312);
            this.BtnDodjeli.Name = "BtnDodjeli";
            this.BtnDodjeli.Size = new System.Drawing.Size(324, 23);
            this.BtnDodjeli.TabIndex = 12;
            this.BtnDodjeli.Text = "Dodjeli grupu kontaktu";
            this.BtnDodjeli.UseVisualStyleBackColor = true;
            this.BtnDodjeli.Click += new System.EventHandler(this.BtnDodjeli_Click);
            // 
            // LstSviKontaktiPoGrupama
            // 
            this.LstSviKontaktiPoGrupama.FormattingEnabled = true;
            this.LstSviKontaktiPoGrupama.Location = new System.Drawing.Point(16, 368);
            this.LstSviKontaktiPoGrupama.Name = "LstSviKontaktiPoGrupama";
            this.LstSviKontaktiPoGrupama.Size = new System.Drawing.Size(324, 212);
            this.LstSviKontaktiPoGrupama.TabIndex = 13;
            // 
            // CboxFilter
            // 
            this.CboxFilter.FormattingEnabled = true;
            this.CboxFilter.Location = new System.Drawing.Point(16, 342);
            this.CboxFilter.Name = "CboxFilter";
            this.CboxFilter.Size = new System.Drawing.Size(324, 21);
            this.CboxFilter.TabIndex = 14;
            this.CboxFilter.SelectedIndexChanged += new System.EventHandler(this.CboxFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 593);
            this.Controls.Add(this.CboxFilter);
            this.Controls.Add(this.LstSviKontaktiPoGrupama);
            this.Controls.Add(this.BtnDodjeli);
            this.Controls.Add(this.LstKontakti);
            this.Controls.Add(this.BtnUnesiKontakt);
            this.Controls.Add(this.TxtBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstGrupe);
            this.Controls.Add(this.BtnDodajGrupu);
            this.Controls.Add(this.CboxVrsteGrupa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNazivGrupe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNazivGrupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxVrsteGrupa;
        private System.Windows.Forms.Button BtnDodajGrupu;
        private System.Windows.Forms.ListBox LstGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBroj;
        private System.Windows.Forms.Button BtnUnesiKontakt;
        private System.Windows.Forms.ListBox LstKontakti;
        private System.Windows.Forms.Button BtnDodjeli;
        private System.Windows.Forms.ListBox LstSviKontaktiPoGrupama;
        private System.Windows.Forms.ComboBox CboxFilter;
    }
}

