namespace Zadatak114
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
            this.TxtNazivKolegija = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUnosOcjeneNazivKolegija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUnosOcjene = new System.Windows.Forms.TextBox();
            this.BtnUnosOcjene = new System.Windows.Forms.Button();
            this.LabelNajbolji = new System.Windows.Forms.Label();
            this.LabelNajlosiji = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtNazivKolegija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos kolegija";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnUnosOcjene);
            this.groupBox2.Controls.Add(this.TxtUnosOcjene);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtUnosOcjeneNazivKolegija);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unos ocjena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv kolegija:";
            // 
            // TxtNazivKolegija
            // 
            this.TxtNazivKolegija.Location = new System.Drawing.Point(10, 37);
            this.TxtNazivKolegija.Name = "TxtNazivKolegija";
            this.TxtNazivKolegija.Size = new System.Drawing.Size(184, 20);
            this.TxtNazivKolegija.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Unos kolegija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv kolegija:";
            // 
            // TxtUnosOcjeneNazivKolegija
            // 
            this.TxtUnosOcjeneNazivKolegija.Location = new System.Drawing.Point(10, 37);
            this.TxtUnosOcjeneNazivKolegija.Name = "TxtUnosOcjeneNazivKolegija";
            this.TxtUnosOcjeneNazivKolegija.Size = new System.Drawing.Size(184, 20);
            this.TxtUnosOcjeneNazivKolegija.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ocjena:";
            // 
            // TxtUnosOcjene
            // 
            this.TxtUnosOcjene.Location = new System.Drawing.Point(10, 79);
            this.TxtUnosOcjene.Name = "TxtUnosOcjene";
            this.TxtUnosOcjene.Size = new System.Drawing.Size(184, 20);
            this.TxtUnosOcjene.TabIndex = 1;
            // 
            // BtnUnosOcjene
            // 
            this.BtnUnosOcjene.Location = new System.Drawing.Point(10, 105);
            this.BtnUnosOcjene.Name = "BtnUnosOcjene";
            this.BtnUnosOcjene.Size = new System.Drawing.Size(184, 23);
            this.BtnUnosOcjene.TabIndex = 2;
            this.BtnUnosOcjene.Text = "Unos ocjene";
            this.BtnUnosOcjene.UseVisualStyleBackColor = true;
            this.BtnUnosOcjene.Click += new System.EventHandler(this.BtnUnosOcjene_Click);
            // 
            // LabelNajbolji
            // 
            this.LabelNajbolji.AutoSize = true;
            this.LabelNajbolji.Location = new System.Drawing.Point(12, 135);
            this.LabelNajbolji.Name = "LabelNajbolji";
            this.LabelNajbolji.Size = new System.Drawing.Size(88, 13);
            this.LabelNajbolji.TabIndex = 2;
            this.LabelNajbolji.Text = "Najbolji kolegij je:";
            this.LabelNajbolji.Click += new System.EventHandler(this.LabelNajbolji_Click);
            // 
            // LabelNajlosiji
            // 
            this.LabelNajlosiji.AutoSize = true;
            this.LabelNajlosiji.Location = new System.Drawing.Point(12, 158);
            this.LabelNajlosiji.Name = "LabelNajlosiji";
            this.LabelNajlosiji.Size = new System.Drawing.Size(89, 13);
            this.LabelNajlosiji.TabIndex = 2;
            this.LabelNajlosiji.Text = "Najlošiji kolegij je:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 184);
            this.Controls.Add(this.LabelNajlosiji);
            this.Controls.Add(this.LabelNajbolji);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNazivKolegija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUnosOcjene;
        private System.Windows.Forms.TextBox TxtUnosOcjene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUnosOcjeneNazivKolegija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelNajbolji;
        private System.Windows.Forms.Label LabelNajlosiji;
    }
}

