namespace Zadatak113
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
            this.TxtUnos = new System.Windows.Forms.TextBox();
            this.BtnUnesiBroj = new System.Windows.Forms.Button();
            this.BtnPrikaziSortiranuListu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj:";
            // 
            // TxtUnos
            // 
            this.TxtUnos.Location = new System.Drawing.Point(48, 10);
            this.TxtUnos.Name = "TxtUnos";
            this.TxtUnos.Size = new System.Drawing.Size(186, 20);
            this.TxtUnos.TabIndex = 1;
            // 
            // BtnUnesiBroj
            // 
            this.BtnUnesiBroj.Location = new System.Drawing.Point(16, 40);
            this.BtnUnesiBroj.Name = "BtnUnesiBroj";
            this.BtnUnesiBroj.Size = new System.Drawing.Size(218, 23);
            this.BtnUnesiBroj.TabIndex = 2;
            this.BtnUnesiBroj.Text = "Unesi";
            this.BtnUnesiBroj.UseVisualStyleBackColor = true;
            this.BtnUnesiBroj.Click += new System.EventHandler(this.BtnUnesiBroj_Click);
            // 
            // BtnPrikaziSortiranuListu
            // 
            this.BtnPrikaziSortiranuListu.Location = new System.Drawing.Point(16, 70);
            this.BtnPrikaziSortiranuListu.Name = "BtnPrikaziSortiranuListu";
            this.BtnPrikaziSortiranuListu.Size = new System.Drawing.Size(218, 23);
            this.BtnPrikaziSortiranuListu.TabIndex = 3;
            this.BtnPrikaziSortiranuListu.Text = "Prikaz sortirane liste";
            this.BtnPrikaziSortiranuListu.UseVisualStyleBackColor = true;
            this.BtnPrikaziSortiranuListu.Click += new System.EventHandler(this.BtnPrikaziSortiranuListu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 100);
            this.Controls.Add(this.BtnPrikaziSortiranuListu);
            this.Controls.Add(this.BtnUnesiBroj);
            this.Controls.Add(this.TxtUnos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUnos;
        private System.Windows.Forms.Button BtnUnesiBroj;
        private System.Windows.Forms.Button BtnPrikaziSortiranuListu;
    }
}

