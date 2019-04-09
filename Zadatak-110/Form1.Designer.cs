namespace Zadatak_110
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUneseniTekst = new System.Windows.Forms.TextBox();
            this.ListaStatistike = new System.Windows.Forms.ListBox();
            this.TimerPromjene = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uneseni tekst:";
            // 
            // TxtUneseniTekst
            // 
            this.TxtUneseniTekst.Location = new System.Drawing.Point(13, 30);
            this.TxtUneseniTekst.Name = "TxtUneseniTekst";
            this.TxtUneseniTekst.Size = new System.Drawing.Size(145, 20);
            this.TxtUneseniTekst.TabIndex = 1;
            this.TxtUneseniTekst.TextChanged += new System.EventHandler(this.TxtUneseniTekst_TextChanged);
            // 
            // ListaStatistike
            // 
            this.ListaStatistike.FormattingEnabled = true;
            this.ListaStatistike.Location = new System.Drawing.Point(13, 61);
            this.ListaStatistike.Name = "ListaStatistike";
            this.ListaStatistike.Size = new System.Drawing.Size(145, 381);
            this.ListaStatistike.TabIndex = 3;
            // 
            // TimerPromjene
            // 
            this.TimerPromjene.Enabled = true;
            this.TimerPromjene.Tick += new System.EventHandler(this.TimerPromjene_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 450);
            this.Controls.Add(this.ListaStatistike);
            this.Controls.Add(this.TxtUneseniTekst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUneseniTekst;
        private System.Windows.Forms.ListBox ListaStatistike;
        private System.Windows.Forms.Timer TimerPromjene;
    }
}

