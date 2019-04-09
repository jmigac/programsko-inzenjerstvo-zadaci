namespace Zadatak123
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
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.ListaPovijestPretrazivanja = new System.Windows.Forms.ListBox();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VrijemeUcitavanja = new System.Windows.Forms.Timer(this.components);
            this.BtnNazad = new System.Windows.Forms.Button();
            this.BtnOsvjezi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(1, 60);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(859, 468);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            // 
            // ListaPovijestPretrazivanja
            // 
            this.ListaPovijestPretrazivanja.FormattingEnabled = true;
            this.ListaPovijestPretrazivanja.Location = new System.Drawing.Point(867, 35);
            this.ListaPovijestPretrazivanja.Name = "ListaPovijestPretrazivanja";
            this.ListaPovijestPretrazivanja.Size = new System.Drawing.Size(280, 498);
            this.ListaPovijestPretrazivanja.TabIndex = 1;
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(50, 12);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(810, 20);
            this.TxtLink.TabIndex = 2;
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Location = new System.Drawing.Point(867, 9);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(280, 23);
            this.BtnPretrazi.TabIndex = 3;
            this.BtnPretrazi.Text = "Pretraži";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VrijemeUcitavanja
            // 
            this.VrijemeUcitavanja.Interval = 10;
            this.VrijemeUcitavanja.Tick += new System.EventHandler(this.VrijemeUcitavanja_Tick);
            // 
            // BtnNazad
            // 
            this.BtnNazad.Location = new System.Drawing.Point(15, 35);
            this.BtnNazad.Name = "BtnNazad";
            this.BtnNazad.Size = new System.Drawing.Size(129, 23);
            this.BtnNazad.TabIndex = 5;
            this.BtnNazad.Text = "Prethodna web stranica";
            this.BtnNazad.UseVisualStyleBackColor = true;
            this.BtnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // BtnOsvjezi
            // 
            this.BtnOsvjezi.Location = new System.Drawing.Point(150, 35);
            this.BtnOsvjezi.Name = "BtnOsvjezi";
            this.BtnOsvjezi.Size = new System.Drawing.Size(129, 23);
            this.BtnOsvjezi.TabIndex = 5;
            this.BtnOsvjezi.Text = "Osvježi web stranicu\r\n";
            this.BtnOsvjezi.UseVisualStyleBackColor = true;
            this.BtnOsvjezi.Click += new System.EventHandler(this.BtnOsvjezi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 531);
            this.Controls.Add(this.BtnOsvjezi);
            this.Controls.Add(this.BtnNazad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.TxtLink);
            this.Controls.Add(this.ListaPovijestPretrazivanja);
            this.Controls.Add(this.WebBrowser);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Web Preglednik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.ListBox ListaPovijestPretrazivanja;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer VrijemeUcitavanja;
        private System.Windows.Forms.Button BtnNazad;
        private System.Windows.Forms.Button BtnOsvjezi;
    }
}

