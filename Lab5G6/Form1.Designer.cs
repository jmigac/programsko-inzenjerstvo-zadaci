namespace Lab5G6
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
            this.LstDijagnostika = new System.Windows.Forms.ListBox();
            this.BtnZapocniDijagnostiku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstDijagnostika
            // 
            this.LstDijagnostika.FormattingEnabled = true;
            this.LstDijagnostika.Location = new System.Drawing.Point(13, 13);
            this.LstDijagnostika.Name = "LstDijagnostika";
            this.LstDijagnostika.Size = new System.Drawing.Size(236, 238);
            this.LstDijagnostika.TabIndex = 0;
            // 
            // BtnZapocniDijagnostiku
            // 
            this.BtnZapocniDijagnostiku.Location = new System.Drawing.Point(13, 258);
            this.BtnZapocniDijagnostiku.Name = "BtnZapocniDijagnostiku";
            this.BtnZapocniDijagnostiku.Size = new System.Drawing.Size(236, 23);
            this.BtnZapocniDijagnostiku.TabIndex = 1;
            this.BtnZapocniDijagnostiku.Text = "Zapocni dijagnostiku";
            this.BtnZapocniDijagnostiku.UseVisualStyleBackColor = true;
            this.BtnZapocniDijagnostiku.Click += new System.EventHandler(this.BtnZapocniDijagnostiku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 291);
            this.Controls.Add(this.BtnZapocniDijagnostiku);
            this.Controls.Add(this.LstDijagnostika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstDijagnostika;
        private System.Windows.Forms.Button BtnZapocniDijagnostiku;
    }
}

