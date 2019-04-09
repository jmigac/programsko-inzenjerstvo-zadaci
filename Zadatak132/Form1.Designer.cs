namespace Zadatak132
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTecaj = new System.Windows.Forms.TextBox();
            this.BtnPostavi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValuta1 = new System.Windows.Forms.TextBox();
            this.BtnIzracunaj = new System.Windows.Forms.Button();
            this.ListaPretvorbi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPostavi);
            this.groupBox1.Controls.Add(this.TxtTecaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postavljanje nove vrijednosti tečaja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnIzracunaj);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtValuta1);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izračunaj pretvorbu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrijednost tečaja:";
            // 
            // TxtTecaj
            // 
            this.TxtTecaj.Location = new System.Drawing.Point(10, 37);
            this.TxtTecaj.Name = "TxtTecaj";
            this.TxtTecaj.Size = new System.Drawing.Size(184, 20);
            this.TxtTecaj.TabIndex = 1;
            // 
            // BtnPostavi
            // 
            this.BtnPostavi.Location = new System.Drawing.Point(10, 64);
            this.BtnPostavi.Name = "BtnPostavi";
            this.BtnPostavi.Size = new System.Drawing.Size(184, 23);
            this.BtnPostavi.TabIndex = 2;
            this.BtnPostavi.Text = "Postavi";
            this.BtnPostavi.UseVisualStyleBackColor = true;
            this.BtnPostavi.Click += new System.EventHandler(this.BtnPostavi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valuta 1:";
            // 
            // TxtValuta1
            // 
            this.TxtValuta1.Location = new System.Drawing.Point(10, 36);
            this.TxtValuta1.Name = "TxtValuta1";
            this.TxtValuta1.Size = new System.Drawing.Size(184, 20);
            this.TxtValuta1.TabIndex = 1;
            // 
            // BtnIzracunaj
            // 
            this.BtnIzracunaj.Location = new System.Drawing.Point(10, 62);
            this.BtnIzracunaj.Name = "BtnIzracunaj";
            this.BtnIzracunaj.Size = new System.Drawing.Size(184, 23);
            this.BtnIzracunaj.TabIndex = 2;
            this.BtnIzracunaj.Text = "Izracunaj";
            this.BtnIzracunaj.UseVisualStyleBackColor = true;
            this.BtnIzracunaj.Click += new System.EventHandler(this.BtnIzracunaj_Click);
            // 
            // ListaPretvorbi
            // 
            this.ListaPretvorbi.FormattingEnabled = true;
            this.ListaPretvorbi.Location = new System.Drawing.Point(220, 13);
            this.ListaPretvorbi.Name = "ListaPretvorbi";
            this.ListaPretvorbi.Size = new System.Drawing.Size(155, 199);
            this.ListaPretvorbi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 218);
            this.Controls.Add(this.ListaPretvorbi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPostavi;
        private System.Windows.Forms.TextBox TxtTecaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnIzracunaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValuta1;
        private System.Windows.Forms.ListBox ListaPretvorbi;
    }
}

