namespace Vjezba1Lab5
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
            this.TxtKnjiga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDodajKnjigu = new System.Windows.Forms.Button();
            this.LstKnjiga = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDodajAutora = new System.Windows.Forms.Button();
            this.LstAutora = new System.Windows.Forms.ListBox();
            this.BtnGenerateKnjige = new System.Windows.Forms.Button();
            this.BtnUkloniAutora = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUsporedba = new System.Windows.Forms.TextBox();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.LstPretraga = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv knjige:";
            // 
            // TxtKnjiga
            // 
            this.TxtKnjiga.Location = new System.Drawing.Point(16, 30);
            this.TxtKnjiga.Name = "TxtKnjiga";
            this.TxtKnjiga.Size = new System.Drawing.Size(199, 20);
            this.TxtKnjiga.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Knjiga1;2015;1";
            // 
            // BtnDodajKnjigu
            // 
            this.BtnDodajKnjigu.Location = new System.Drawing.Point(16, 74);
            this.BtnDodajKnjigu.Name = "BtnDodajKnjigu";
            this.BtnDodajKnjigu.Size = new System.Drawing.Size(199, 23);
            this.BtnDodajKnjigu.TabIndex = 3;
            this.BtnDodajKnjigu.Text = "Dodaj knjigu";
            this.BtnDodajKnjigu.UseVisualStyleBackColor = true;
            this.BtnDodajKnjigu.Click += new System.EventHandler(this.BtnDodajKnjigu_Click);
            // 
            // LstKnjiga
            // 
            this.LstKnjiga.FormattingEnabled = true;
            this.LstKnjiga.Location = new System.Drawing.Point(16, 104);
            this.LstKnjiga.Name = "LstKnjiga";
            this.LstKnjiga.Size = new System.Drawing.Size(199, 160);
            this.LstKnjiga.TabIndex = 4;
            this.LstKnjiga.SelectedIndexChanged += new System.EventHandler(this.LstKnjiga_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv autora:";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(239, 29);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(185, 20);
            this.TxtAutor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(236, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jurica;Migač;jmigac@foi.hr";
            // 
            // BtnDodajAutora
            // 
            this.BtnDodajAutora.Location = new System.Drawing.Point(239, 73);
            this.BtnDodajAutora.Name = "BtnDodajAutora";
            this.BtnDodajAutora.Size = new System.Drawing.Size(185, 23);
            this.BtnDodajAutora.TabIndex = 7;
            this.BtnDodajAutora.Text = "Dodaj autora";
            this.BtnDodajAutora.UseVisualStyleBackColor = true;
            this.BtnDodajAutora.Click += new System.EventHandler(this.BtnDodajAutora_Click);
            // 
            // LstAutora
            // 
            this.LstAutora.FormattingEnabled = true;
            this.LstAutora.Location = new System.Drawing.Point(239, 104);
            this.LstAutora.Name = "LstAutora";
            this.LstAutora.Size = new System.Drawing.Size(185, 160);
            this.LstAutora.TabIndex = 8;
            // 
            // BtnGenerateKnjige
            // 
            this.BtnGenerateKnjige.Location = new System.Drawing.Point(431, 26);
            this.BtnGenerateKnjige.Name = "BtnGenerateKnjige";
            this.BtnGenerateKnjige.Size = new System.Drawing.Size(181, 71);
            this.BtnGenerateKnjige.TabIndex = 9;
            this.BtnGenerateKnjige.Text = "Dodaj 5 knjiga";
            this.BtnGenerateKnjige.UseVisualStyleBackColor = true;
            this.BtnGenerateKnjige.Click += new System.EventHandler(this.BtnGenerateKnjige_Click);
            // 
            // BtnUkloniAutora
            // 
            this.BtnUkloniAutora.Location = new System.Drawing.Point(431, 104);
            this.BtnUkloniAutora.Name = "BtnUkloniAutora";
            this.BtnUkloniAutora.Size = new System.Drawing.Size(181, 64);
            this.BtnUkloniAutora.TabIndex = 10;
            this.BtnUkloniAutora.Text = "Ukloni autora";
            this.BtnUkloniAutora.UseVisualStyleBackColor = true;
            this.BtnUkloniAutora.Click += new System.EventHandler(this.BtnUkloniAutora_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pretraživanje knjižnice:";
            // 
            // TxtUsporedba
            // 
            this.TxtUsporedba.Location = new System.Drawing.Point(16, 288);
            this.TxtUsporedba.Name = "TxtUsporedba";
            this.TxtUsporedba.Size = new System.Drawing.Size(408, 20);
            this.TxtUsporedba.TabIndex = 12;
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Location = new System.Drawing.Point(431, 286);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(181, 23);
            this.BtnPretrazi.TabIndex = 13;
            this.BtnPretrazi.Text = "Pretraži";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // LstPretraga
            // 
            this.LstPretraga.FormattingEnabled = true;
            this.LstPretraga.Location = new System.Drawing.Point(16, 315);
            this.LstPretraga.Name = "LstPretraga";
            this.LstPretraga.Size = new System.Drawing.Size(596, 95);
            this.LstPretraga.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 418);
            this.Controls.Add(this.LstPretraga);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.TxtUsporedba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUkloniAutora);
            this.Controls.Add(this.BtnGenerateKnjige);
            this.Controls.Add(this.LstAutora);
            this.Controls.Add(this.BtnDodajAutora);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstKnjiga);
            this.Controls.Add(this.BtnDodajKnjigu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKnjiga);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKnjiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodajKnjigu;
        private System.Windows.Forms.ListBox LstKnjiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDodajAutora;
        private System.Windows.Forms.ListBox LstAutora;
        private System.Windows.Forms.Button BtnGenerateKnjige;
        private System.Windows.Forms.Button BtnUkloniAutora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUsporedba;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.ListBox LstPretraga;
    }
}

