namespace Lab5G4
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
            this.TxtImeZaposlenici = new System.Windows.Forms.TextBox();
            this.CboxOdjeli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUnosZaposlenika = new System.Windows.Forms.Button();
            this.LstZaposlenici = new System.Windows.Forms.ListBox();
            this.BtnPremjestiZaposlenika = new System.Windows.Forms.Button();
            this.LblZaposlenik = new System.Windows.Forms.Label();
            this.LblOdjel = new System.Windows.Forms.Label();
            this.CboxOdjelPremjestaja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime zaposlenika:";
            // 
            // TxtImeZaposlenici
            // 
            this.TxtImeZaposlenici.Location = new System.Drawing.Point(15, 26);
            this.TxtImeZaposlenici.Name = "TxtImeZaposlenici";
            this.TxtImeZaposlenici.Size = new System.Drawing.Size(246, 20);
            this.TxtImeZaposlenici.TabIndex = 1;
            // 
            // CboxOdjeli
            // 
            this.CboxOdjeli.FormattingEnabled = true;
            this.CboxOdjeli.Location = new System.Drawing.Point(15, 69);
            this.CboxOdjeli.Name = "CboxOdjeli";
            this.CboxOdjeli.Size = new System.Drawing.Size(246, 21);
            this.CboxOdjeli.TabIndex = 2;
            this.CboxOdjeli.SelectedIndexChanged += new System.EventHandler(this.CboxOdjeli_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odjel:";
            // 
            // BtnUnosZaposlenika
            // 
            this.BtnUnosZaposlenika.Location = new System.Drawing.Point(15, 97);
            this.BtnUnosZaposlenika.Name = "BtnUnosZaposlenika";
            this.BtnUnosZaposlenika.Size = new System.Drawing.Size(246, 23);
            this.BtnUnosZaposlenika.TabIndex = 4;
            this.BtnUnosZaposlenika.Text = "Dodaj zaposlenika";
            this.BtnUnosZaposlenika.UseVisualStyleBackColor = true;
            this.BtnUnosZaposlenika.Click += new System.EventHandler(this.BtnUnosZaposlenika_Click);
            // 
            // LstZaposlenici
            // 
            this.LstZaposlenici.FormattingEnabled = true;
            this.LstZaposlenici.Location = new System.Drawing.Point(15, 127);
            this.LstZaposlenici.Name = "LstZaposlenici";
            this.LstZaposlenici.Size = new System.Drawing.Size(246, 160);
            this.LstZaposlenici.TabIndex = 8;
            this.LstZaposlenici.SelectedIndexChanged += new System.EventHandler(this.LstZaposlenici_SelectedIndexChanged);
            // 
            // BtnPremjestiZaposlenika
            // 
            this.BtnPremjestiZaposlenika.Location = new System.Drawing.Point(15, 379);
            this.BtnPremjestiZaposlenika.Name = "BtnPremjestiZaposlenika";
            this.BtnPremjestiZaposlenika.Size = new System.Drawing.Size(246, 23);
            this.BtnPremjestiZaposlenika.TabIndex = 10;
            this.BtnPremjestiZaposlenika.Text = "Premjesti zaposlenika";
            this.BtnPremjestiZaposlenika.UseVisualStyleBackColor = true;
            this.BtnPremjestiZaposlenika.Click += new System.EventHandler(this.BtnPremjestiZaposlenika_Click);
            // 
            // LblZaposlenik
            // 
            this.LblZaposlenik.AutoSize = true;
            this.LblZaposlenik.Location = new System.Drawing.Point(15, 326);
            this.LblZaposlenik.Name = "LblZaposlenik";
            this.LblZaposlenik.Size = new System.Drawing.Size(130, 13);
            this.LblZaposlenik.TabIndex = 11;
            this.LblZaposlenik.Text = "Ime i prezime zaposlenika:";
            // 
            // LblOdjel
            // 
            this.LblOdjel.AutoSize = true;
            this.LblOdjel.Location = new System.Drawing.Point(15, 346);
            this.LblOdjel.Name = "LblOdjel";
            this.LblOdjel.Size = new System.Drawing.Size(74, 13);
            this.LblOdjel.TabIndex = 12;
            this.LblOdjel.Text = "Trenutni odjel:";
            // 
            // CboxOdjelPremjestaja
            // 
            this.CboxOdjelPremjestaja.FormattingEnabled = true;
            this.CboxOdjelPremjestaja.Items.AddRange(new object[] {
            "Prodaja",
            "Marketing"});
            this.CboxOdjelPremjestaja.Location = new System.Drawing.Point(15, 293);
            this.CboxOdjelPremjestaja.Name = "CboxOdjelPremjestaja";
            this.CboxOdjelPremjestaja.Size = new System.Drawing.Size(246, 21);
            this.CboxOdjelPremjestaja.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 414);
            this.Controls.Add(this.LblOdjel);
            this.Controls.Add(this.LblZaposlenik);
            this.Controls.Add(this.BtnPremjestiZaposlenika);
            this.Controls.Add(this.LstZaposlenici);
            this.Controls.Add(this.BtnUnosZaposlenika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboxOdjelPremjestaja);
            this.Controls.Add(this.CboxOdjeli);
            this.Controls.Add(this.TxtImeZaposlenici);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtImeZaposlenici;
        private System.Windows.Forms.ComboBox CboxOdjeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUnosZaposlenika;
        private System.Windows.Forms.ListBox LstZaposlenici;
        private System.Windows.Forms.Button BtnPremjestiZaposlenika;
        private System.Windows.Forms.Label LblZaposlenik;
        private System.Windows.Forms.Label LblOdjel;
        private System.Windows.Forms.ComboBox CboxOdjelPremjestaja;
    }
}

