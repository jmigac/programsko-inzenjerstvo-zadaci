namespace Zadatak124
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVisok = new System.Windows.Forms.TextBox();
            this.TxtSrednji = new System.Windows.Forms.TextBox();
            this.TxtNiski = new System.Windows.Forms.TextBox();
            this.BtnPostavke = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtVisina = new System.Windows.Forms.TextBox();
            this.TxtMasa = new System.Windows.Forms.TextBox();
            this.BtnIzracunaj = new System.Windows.Forms.Button();
            this.LabelaIspis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPostavke);
            this.groupBox1.Controls.Add(this.TxtNiski);
            this.groupBox1.Controls.Add(this.TxtSrednji);
            this.groupBox1.Controls.Add(this.TxtVisok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postavke BMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Srednji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niski:";
            // 
            // TxtVisok
            // 
            this.TxtVisok.Location = new System.Drawing.Point(51, 17);
            this.TxtVisok.Name = "TxtVisok";
            this.TxtVisok.Size = new System.Drawing.Size(212, 20);
            this.TxtVisok.TabIndex = 3;
            // 
            // TxtSrednji
            // 
            this.TxtSrednji.Location = new System.Drawing.Point(51, 44);
            this.TxtSrednji.Name = "TxtSrednji";
            this.TxtSrednji.Size = new System.Drawing.Size(212, 20);
            this.TxtSrednji.TabIndex = 3;
            // 
            // TxtNiski
            // 
            this.TxtNiski.Location = new System.Drawing.Point(51, 71);
            this.TxtNiski.Name = "TxtNiski";
            this.TxtNiski.Size = new System.Drawing.Size(212, 20);
            this.TxtNiski.TabIndex = 3;
            // 
            // BtnPostavke
            // 
            this.BtnPostavke.Location = new System.Drawing.Point(13, 92);
            this.BtnPostavke.Name = "BtnPostavke";
            this.BtnPostavke.Size = new System.Drawing.Size(250, 23);
            this.BtnPostavke.TabIndex = 4;
            this.BtnPostavke.Text = "Postavi postavke";
            this.BtnPostavke.UseVisualStyleBackColor = true;
            this.BtnPostavke.Click += new System.EventHandler(this.BtnPostavke_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnIzracunaj);
            this.groupBox2.Controls.Add(this.TxtMasa);
            this.groupBox2.Controls.Add(this.TxtVisina);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisnički unos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Visina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Masa:";
            // 
            // TxtVisina
            // 
            this.TxtVisina.Location = new System.Drawing.Point(49, 17);
            this.TxtVisina.Name = "TxtVisina";
            this.TxtVisina.Size = new System.Drawing.Size(214, 20);
            this.TxtVisina.TabIndex = 2;
            // 
            // TxtMasa
            // 
            this.TxtMasa.Location = new System.Drawing.Point(49, 48);
            this.TxtMasa.Name = "TxtMasa";
            this.TxtMasa.Size = new System.Drawing.Size(214, 20);
            this.TxtMasa.TabIndex = 2;
            // 
            // BtnIzracunaj
            // 
            this.BtnIzracunaj.Location = new System.Drawing.Point(10, 83);
            this.BtnIzracunaj.Name = "BtnIzracunaj";
            this.BtnIzracunaj.Size = new System.Drawing.Size(253, 23);
            this.BtnIzracunaj.TabIndex = 3;
            this.BtnIzracunaj.Text = "Izračunaj";
            this.BtnIzracunaj.UseVisualStyleBackColor = true;
            this.BtnIzracunaj.Click += new System.EventHandler(this.BtnIzracunaj_Click);
            // 
            // LabelaIspis
            // 
            this.LabelaIspis.AutoSize = true;
            this.LabelaIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelaIspis.Location = new System.Drawing.Point(8, 258);
            this.LabelaIspis.Name = "LabelaIspis";
            this.LabelaIspis.Size = new System.Drawing.Size(64, 29);
            this.LabelaIspis.TabIndex = 2;
            this.LabelaIspis.Text = "BMI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 297);
            this.Controls.Add(this.LabelaIspis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BMI kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPostavke;
        private System.Windows.Forms.TextBox TxtSrednji;
        private System.Windows.Forms.TextBox TxtVisok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnIzracunaj;
        private System.Windows.Forms.TextBox TxtMasa;
        private System.Windows.Forms.TextBox TxtVisina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelaIspis;
        private System.Windows.Forms.TextBox TxtNiski;
    }
}

