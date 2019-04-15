namespace Lab5V3
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
            this.TxtNazivTrgovine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdresaTrgovine = new System.Windows.Forms.TextBox();
            this.BtnDodajTrgovinu = new System.Windows.Forms.Button();
            this.LstTrgovine = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNazivArtikla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCijenaArtikla = new System.Windows.Forms.TextBox();
            this.BtnUnesiArtikl = new System.Windows.Forms.Button();
            this.LstArtikli = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKolicinaArtikla = new System.Windows.Forms.TextBox();
            this.BtnUnesiRacun = new System.Windows.Forms.Button();
            this.LblOdabranaTrgovina = new System.Windows.Forms.Label();
            this.LblOdabranArtikl = new System.Windows.Forms.Label();
            this.LstArtiklaTrgovine = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv trgovine:";
            // 
            // TxtNazivTrgovine
            // 
            this.TxtNazivTrgovine.Location = new System.Drawing.Point(16, 30);
            this.TxtNazivTrgovine.Name = "TxtNazivTrgovine";
            this.TxtNazivTrgovine.Size = new System.Drawing.Size(160, 20);
            this.TxtNazivTrgovine.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa trgovine:";
            // 
            // TxtAdresaTrgovine
            // 
            this.TxtAdresaTrgovine.Location = new System.Drawing.Point(16, 74);
            this.TxtAdresaTrgovine.Name = "TxtAdresaTrgovine";
            this.TxtAdresaTrgovine.Size = new System.Drawing.Size(160, 20);
            this.TxtAdresaTrgovine.TabIndex = 3;
            // 
            // BtnDodajTrgovinu
            // 
            this.BtnDodajTrgovinu.Location = new System.Drawing.Point(16, 101);
            this.BtnDodajTrgovinu.Name = "BtnDodajTrgovinu";
            this.BtnDodajTrgovinu.Size = new System.Drawing.Size(160, 23);
            this.BtnDodajTrgovinu.TabIndex = 4;
            this.BtnDodajTrgovinu.Text = "Dodaj trgovinu";
            this.BtnDodajTrgovinu.UseVisualStyleBackColor = true;
            this.BtnDodajTrgovinu.Click += new System.EventHandler(this.BtnDodajTrgovinu_Click);
            // 
            // LstTrgovine
            // 
            this.LstTrgovine.FormattingEnabled = true;
            this.LstTrgovine.Location = new System.Drawing.Point(16, 131);
            this.LstTrgovine.Name = "LstTrgovine";
            this.LstTrgovine.Size = new System.Drawing.Size(160, 147);
            this.LstTrgovine.TabIndex = 5;
            this.LstTrgovine.SelectedIndexChanged += new System.EventHandler(this.LstTrgovine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv artikla:";
            // 
            // TxtNazivArtikla
            // 
            this.TxtNazivArtikla.Location = new System.Drawing.Point(209, 29);
            this.TxtNazivArtikla.Name = "TxtNazivArtikla";
            this.TxtNazivArtikla.Size = new System.Drawing.Size(156, 20);
            this.TxtNazivArtikla.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena artikla:";
            // 
            // TxtCijenaArtikla
            // 
            this.TxtCijenaArtikla.Location = new System.Drawing.Point(209, 73);
            this.TxtCijenaArtikla.Name = "TxtCijenaArtikla";
            this.TxtCijenaArtikla.Size = new System.Drawing.Size(156, 20);
            this.TxtCijenaArtikla.TabIndex = 9;
            // 
            // BtnUnesiArtikl
            // 
            this.BtnUnesiArtikl.Location = new System.Drawing.Point(209, 100);
            this.BtnUnesiArtikl.Name = "BtnUnesiArtikl";
            this.BtnUnesiArtikl.Size = new System.Drawing.Size(156, 23);
            this.BtnUnesiArtikl.TabIndex = 10;
            this.BtnUnesiArtikl.Text = "Unesi artikl";
            this.BtnUnesiArtikl.UseVisualStyleBackColor = true;
            this.BtnUnesiArtikl.Click += new System.EventHandler(this.BtnUnesiArtikl_Click);
            // 
            // LstArtikli
            // 
            this.LstArtikli.FormattingEnabled = true;
            this.LstArtikli.Location = new System.Drawing.Point(209, 131);
            this.LstArtikli.Name = "LstArtikli";
            this.LstArtikli.Size = new System.Drawing.Size(156, 147);
            this.LstArtikli.TabIndex = 11;
            this.LstArtikli.SelectedIndexChanged += new System.EventHandler(this.LstArtikli_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unesi količinu za odabrani artikl:";
            // 
            // TxtKolicinaArtikla
            // 
            this.TxtKolicinaArtikla.Location = new System.Drawing.Point(397, 30);
            this.TxtKolicinaArtikla.Name = "TxtKolicinaArtikla";
            this.TxtKolicinaArtikla.Size = new System.Drawing.Size(156, 20);
            this.TxtKolicinaArtikla.TabIndex = 13;
            // 
            // BtnUnesiRacun
            // 
            this.BtnUnesiRacun.Location = new System.Drawing.Point(397, 57);
            this.BtnUnesiRacun.Name = "BtnUnesiRacun";
            this.BtnUnesiRacun.Size = new System.Drawing.Size(156, 23);
            this.BtnUnesiRacun.TabIndex = 14;
            this.BtnUnesiRacun.Text = "Unesi račun";
            this.BtnUnesiRacun.UseVisualStyleBackColor = true;
            this.BtnUnesiRacun.Click += new System.EventHandler(this.BtnUnesiRacun_Click);
            // 
            // LblOdabranaTrgovina
            // 
            this.LblOdabranaTrgovina.AutoSize = true;
            this.LblOdabranaTrgovina.Location = new System.Drawing.Point(394, 83);
            this.LblOdabranaTrgovina.Name = "LblOdabranaTrgovina";
            this.LblOdabranaTrgovina.Size = new System.Drawing.Size(98, 13);
            this.LblOdabranaTrgovina.TabIndex = 15;
            this.LblOdabranaTrgovina.Text = "Odabrana trgovina:";
            // 
            // LblOdabranArtikl
            // 
            this.LblOdabranArtikl.AutoSize = true;
            this.LblOdabranArtikl.Location = new System.Drawing.Point(394, 105);
            this.LblOdabranArtikl.Name = "LblOdabranArtikl";
            this.LblOdabranArtikl.Size = new System.Drawing.Size(76, 13);
            this.LblOdabranArtikl.TabIndex = 16;
            this.LblOdabranArtikl.Text = "Odabran artikl:";
            // 
            // LstArtiklaTrgovine
            // 
            this.LstArtiklaTrgovine.FormattingEnabled = true;
            this.LstArtiklaTrgovine.Location = new System.Drawing.Point(397, 131);
            this.LstArtiklaTrgovine.Name = "LstArtiklaTrgovine";
            this.LstArtiklaTrgovine.Size = new System.Drawing.Size(156, 147);
            this.LstArtiklaTrgovine.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 288);
            this.Controls.Add(this.LstArtiklaTrgovine);
            this.Controls.Add(this.LblOdabranArtikl);
            this.Controls.Add(this.LblOdabranaTrgovina);
            this.Controls.Add(this.BtnUnesiRacun);
            this.Controls.Add(this.TxtKolicinaArtikla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LstArtikli);
            this.Controls.Add(this.BtnUnesiArtikl);
            this.Controls.Add(this.TxtCijenaArtikla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNazivArtikla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstTrgovine);
            this.Controls.Add(this.BtnDodajTrgovinu);
            this.Controls.Add(this.TxtAdresaTrgovine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNazivTrgovine);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNazivTrgovine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdresaTrgovine;
        private System.Windows.Forms.Button BtnDodajTrgovinu;
        private System.Windows.Forms.ListBox LstTrgovine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNazivArtikla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCijenaArtikla;
        private System.Windows.Forms.Button BtnUnesiArtikl;
        private System.Windows.Forms.ListBox LstArtikli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKolicinaArtikla;
        private System.Windows.Forms.Button BtnUnesiRacun;
        private System.Windows.Forms.Label LblOdabranaTrgovina;
        private System.Windows.Forms.Label LblOdabranArtikl;
        private System.Windows.Forms.ListBox LstArtiklaTrgovine;
    }
}

