namespace Zadatak139
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
            this.TBarCrvena = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TBarPlava = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TBarZelena = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerBoje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TBarCrvena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarPlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarZelena)).BeginInit();
            this.SuspendLayout();
            // 
            // TBarCrvena
            // 
            this.TBarCrvena.Location = new System.Drawing.Point(13, 25);
            this.TBarCrvena.Maximum = 255;
            this.TBarCrvena.Name = "TBarCrvena";
            this.TBarCrvena.Size = new System.Drawing.Size(470, 45);
            this.TBarCrvena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crvena";
            // 
            // TBarPlava
            // 
            this.TBarPlava.Location = new System.Drawing.Point(13, 76);
            this.TBarPlava.Maximum = 255;
            this.TBarPlava.Name = "TBarPlava";
            this.TBarPlava.Size = new System.Drawing.Size(470, 45);
            this.TBarPlava.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plava";
            // 
            // TBarZelena
            // 
            this.TBarZelena.Location = new System.Drawing.Point(13, 124);
            this.TBarZelena.Maximum = 255;
            this.TBarZelena.Name = "TBarZelena";
            this.TBarZelena.Size = new System.Drawing.Size(470, 45);
            this.TBarZelena.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zelena";
            // 
            // TimerBoje
            // 
            this.TimerBoje.Enabled = true;
            this.TimerBoje.Tick += new System.EventHandler(this.TimerBoje_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBarZelena);
            this.Controls.Add(this.TBarPlava);
            this.Controls.Add(this.TBarCrvena);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TBarCrvena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarPlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarZelena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TBarCrvena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TBarPlava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TBarZelena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TimerBoje;
    }
}

