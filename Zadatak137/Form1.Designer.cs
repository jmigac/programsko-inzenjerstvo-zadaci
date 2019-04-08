namespace Zadatak137
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
            this.TxtGlavnica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKamatnaStopa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTrajanjeRacuna = new System.Windows.Forms.TextBox();
            this.BtnOtplatniPlan = new System.Windows.Forms.Button();
            this.ListaIspisOtplate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glavnica:";
            // 
            // TxtGlavnica
            // 
            this.TxtGlavnica.Location = new System.Drawing.Point(95, 12);
            this.TxtGlavnica.Name = "TxtGlavnica";
            this.TxtGlavnica.Size = new System.Drawing.Size(198, 20);
            this.TxtGlavnica.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kamatna stopa:";
            // 
            // TxtKamatnaStopa
            // 
            this.TxtKamatnaStopa.Location = new System.Drawing.Point(95, 38);
            this.TxtKamatnaStopa.Name = "TxtKamatnaStopa";
            this.TxtKamatnaStopa.Size = new System.Drawing.Size(198, 20);
            this.TxtKamatnaStopa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trajanje računa:";
            // 
            // TxtTrajanjeRacuna
            // 
            this.TxtTrajanjeRacuna.Location = new System.Drawing.Point(95, 64);
            this.TxtTrajanjeRacuna.Name = "TxtTrajanjeRacuna";
            this.TxtTrajanjeRacuna.Size = new System.Drawing.Size(198, 20);
            this.TxtTrajanjeRacuna.TabIndex = 3;
            // 
            // BtnOtplatniPlan
            // 
            this.BtnOtplatniPlan.Location = new System.Drawing.Point(15, 96);
            this.BtnOtplatniPlan.Name = "BtnOtplatniPlan";
            this.BtnOtplatniPlan.Size = new System.Drawing.Size(278, 23);
            this.BtnOtplatniPlan.TabIndex = 4;
            this.BtnOtplatniPlan.Text = "Otplani plan";
            this.BtnOtplatniPlan.UseVisualStyleBackColor = true;
            this.BtnOtplatniPlan.Click += new System.EventHandler(this.BtnOtplatniPlan_Click);
            // 
            // ListaIspisOtplate
            // 
            this.ListaIspisOtplate.FormattingEnabled = true;
            this.ListaIspisOtplate.Location = new System.Drawing.Point(15, 126);
            this.ListaIspisOtplate.Name = "ListaIspisOtplate";
            this.ListaIspisOtplate.Size = new System.Drawing.Size(278, 303);
            this.ListaIspisOtplate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.ListaIspisOtplate);
            this.Controls.Add(this.BtnOtplatniPlan);
            this.Controls.Add(this.TxtTrajanjeRacuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKamatnaStopa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGlavnica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otplatni plan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGlavnica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKamatnaStopa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTrajanjeRacuna;
        private System.Windows.Forms.Button BtnOtplatniPlan;
        private System.Windows.Forms.ListBox ListaIspisOtplate;
    }
}

