namespace Zadatak125
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
            this.TxtSadrzaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUnesiNukleobazu = new System.Windows.Forms.Button();
            this.ListaNukleobaza = new System.Windows.Forms.ListBox();
            this.BtnIspisivanjeParova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSadrzaj
            // 
            this.TxtSadrzaj.Location = new System.Drawing.Point(12, 29);
            this.TxtSadrzaj.Name = "TxtSadrzaj";
            this.TxtSadrzaj.Size = new System.Drawing.Size(328, 20);
            this.TxtSadrzaj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi nukleobaze:";
            // 
            // BtnUnesiNukleobazu
            // 
            this.BtnUnesiNukleobazu.Location = new System.Drawing.Point(12, 56);
            this.BtnUnesiNukleobazu.Name = "BtnUnesiNukleobazu";
            this.BtnUnesiNukleobazu.Size = new System.Drawing.Size(328, 23);
            this.BtnUnesiNukleobazu.TabIndex = 2;
            this.BtnUnesiNukleobazu.Text = "Unesi";
            this.BtnUnesiNukleobazu.UseVisualStyleBackColor = true;
            this.BtnUnesiNukleobazu.Click += new System.EventHandler(this.BtnUnesiNukleobazu_Click);
            // 
            // ListaNukleobaza
            // 
            this.ListaNukleobaza.FormattingEnabled = true;
            this.ListaNukleobaza.Location = new System.Drawing.Point(12, 112);
            this.ListaNukleobaza.Name = "ListaNukleobaza";
            this.ListaNukleobaza.Size = new System.Drawing.Size(328, 329);
            this.ListaNukleobaza.TabIndex = 3;
            // 
            // BtnIspisivanjeParova
            // 
            this.BtnIspisivanjeParova.Location = new System.Drawing.Point(13, 86);
            this.BtnIspisivanjeParova.Name = "BtnIspisivanjeParova";
            this.BtnIspisivanjeParova.Size = new System.Drawing.Size(327, 23);
            this.BtnIspisivanjeParova.TabIndex = 4;
            this.BtnIspisivanjeParova.Text = "Ispis nukleobaza";
            this.BtnIspisivanjeParova.UseVisualStyleBackColor = true;
            this.BtnIspisivanjeParova.Click += new System.EventHandler(this.BtnIspisivanjeParova_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.BtnIspisivanjeParova);
            this.Controls.Add(this.ListaNukleobaza);
            this.Controls.Add(this.BtnUnesiNukleobazu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSadrzaj);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ispisivanje parova nukleobaza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSadrzaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUnesiNukleobazu;
        private System.Windows.Forms.ListBox ListaNukleobaza;
        private System.Windows.Forms.Button BtnIspisivanjeParova;
    }
}

