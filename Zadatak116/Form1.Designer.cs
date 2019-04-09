namespace Zadatak116
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnUnosValute = new System.Windows.Forms.Button();
            this.TxtProdajni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKupoprodajni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNazivValute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaSvihValuta = new System.Windows.Forms.ListBox();
            this.TimerIspisUListe = new System.Windows.Forms.Timer(this.components);
            this.ListaPretvorbi = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVrijednostPretvorbe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioKupoprodajni = new System.Windows.Forms.RadioButton();
            this.RadioProdajni = new System.Windows.Forms.RadioButton();
            this.BtnIzracunaj = new System.Windows.Forms.Button();
            this.TxtNazivPretvorbe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUnosValute);
            this.groupBox1.Controls.Add(this.TxtProdajni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtKupoprodajni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNazivValute);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos valute";
            // 
            // BtnUnosValute
            // 
            this.BtnUnosValute.Location = new System.Drawing.Point(10, 149);
            this.BtnUnosValute.Name = "BtnUnosValute";
            this.BtnUnosValute.Size = new System.Drawing.Size(184, 23);
            this.BtnUnosValute.TabIndex = 4;
            this.BtnUnosValute.Text = "Unesi";
            this.BtnUnosValute.UseVisualStyleBackColor = true;
            this.BtnUnosValute.Click += new System.EventHandler(this.BtnUnosValute_Click);
            // 
            // TxtProdajni
            // 
            this.TxtProdajni.Location = new System.Drawing.Point(10, 122);
            this.TxtProdajni.Name = "TxtProdajni";
            this.TxtProdajni.Size = new System.Drawing.Size(184, 20);
            this.TxtProdajni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prodajni tečaj:";
            // 
            // TxtKupoprodajni
            // 
            this.TxtKupoprodajni.Location = new System.Drawing.Point(10, 77);
            this.TxtKupoprodajni.Name = "TxtKupoprodajni";
            this.TxtKupoprodajni.Size = new System.Drawing.Size(184, 20);
            this.TxtKupoprodajni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kupoprodajni tečaj:";
            // 
            // TxtNazivValute
            // 
            this.TxtNazivValute.Location = new System.Drawing.Point(10, 37);
            this.TxtNazivValute.Name = "TxtNazivValute";
            this.TxtNazivValute.Size = new System.Drawing.Size(169, 20);
            this.TxtNazivValute.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv valute:";
            // 
            // ListaSvihValuta
            // 
            this.ListaSvihValuta.FormattingEnabled = true;
            this.ListaSvihValuta.Location = new System.Drawing.Point(398, 13);
            this.ListaSvihValuta.Name = "ListaSvihValuta";
            this.ListaSvihValuta.Size = new System.Drawing.Size(151, 186);
            this.ListaSvihValuta.TabIndex = 1;
            // 
            // TimerIspisUListe
            // 
            this.TimerIspisUListe.Enabled = true;
            this.TimerIspisUListe.Interval = 3000;
            this.TimerIspisUListe.Tick += new System.EventHandler(this.TimerIspisUListe_Tick);
            // 
            // ListaPretvorbi
            // 
            this.ListaPretvorbi.FormattingEnabled = true;
            this.ListaPretvorbi.Location = new System.Drawing.Point(556, 13);
            this.ListaPretvorbi.Name = "ListaPretvorbi";
            this.ListaPretvorbi.Size = new System.Drawing.Size(338, 186);
            this.ListaPretvorbi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Naziv valute:";
            // 
            // TxtVrijednostPretvorbe
            // 
            this.TxtVrijednostPretvorbe.Location = new System.Drawing.Point(223, 90);
            this.TxtVrijednostPretvorbe.Name = "TxtVrijednostPretvorbe";
            this.TxtVrijednostPretvorbe.Size = new System.Drawing.Size(169, 20);
            this.TxtVrijednostPretvorbe.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vrijednost pretvorbe:";
            // 
            // RadioKupoprodajni
            // 
            this.RadioKupoprodajni.AutoSize = true;
            this.RadioKupoprodajni.Location = new System.Drawing.Point(223, 118);
            this.RadioKupoprodajni.Name = "RadioKupoprodajni";
            this.RadioKupoprodajni.Size = new System.Drawing.Size(87, 17);
            this.RadioKupoprodajni.TabIndex = 7;
            this.RadioKupoprodajni.TabStop = true;
            this.RadioKupoprodajni.Text = "Kupoprodajni";
            this.RadioKupoprodajni.UseVisualStyleBackColor = true;
            // 
            // RadioProdajni
            // 
            this.RadioProdajni.AutoSize = true;
            this.RadioProdajni.Location = new System.Drawing.Point(223, 141);
            this.RadioProdajni.Name = "RadioProdajni";
            this.RadioProdajni.Size = new System.Drawing.Size(63, 17);
            this.RadioProdajni.TabIndex = 8;
            this.RadioProdajni.TabStop = true;
            this.RadioProdajni.Text = "Prodajni";
            this.RadioProdajni.UseVisualStyleBackColor = true;
            // 
            // BtnIzracunaj
            // 
            this.BtnIzracunaj.Location = new System.Drawing.Point(223, 162);
            this.BtnIzracunaj.Name = "BtnIzracunaj";
            this.BtnIzracunaj.Size = new System.Drawing.Size(169, 23);
            this.BtnIzracunaj.TabIndex = 9;
            this.BtnIzracunaj.Text = "Izracunaj";
            this.BtnIzracunaj.UseVisualStyleBackColor = true;
            this.BtnIzracunaj.Click += new System.EventHandler(this.BtnIzracunaj_Click);
            // 
            // TxtNazivPretvorbe
            // 
            this.TxtNazivPretvorbe.Location = new System.Drawing.Point(223, 48);
            this.TxtNazivPretvorbe.Name = "TxtNazivPretvorbe";
            this.TxtNazivPretvorbe.Size = new System.Drawing.Size(169, 20);
            this.TxtNazivPretvorbe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 213);
            this.Controls.Add(this.BtnIzracunaj);
            this.Controls.Add(this.RadioProdajni);
            this.Controls.Add(this.RadioKupoprodajni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaPretvorbi);
            this.Controls.Add(this.ListaSvihValuta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtNazivPretvorbe);
            this.Controls.Add(this.TxtVrijednostPretvorbe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnUnosValute;
        private System.Windows.Forms.TextBox TxtProdajni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKupoprodajni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNazivValute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaSvihValuta;
        private System.Windows.Forms.Timer TimerIspisUListe;
        private System.Windows.Forms.ListBox ListaPretvorbi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVrijednostPretvorbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioKupoprodajni;
        private System.Windows.Forms.RadioButton RadioProdajni;
        private System.Windows.Forms.Button BtnIzracunaj;
        private System.Windows.Forms.TextBox TxtNazivPretvorbe;
    }
}

