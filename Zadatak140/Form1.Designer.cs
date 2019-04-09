namespace Zadatak140
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrviBroj = new System.Windows.Forms.TextBox();
            this.TxtDrugiBroj = new System.Windows.Forms.TextBox();
            this.TxtTreciBroj = new System.Windows.Forms.TextBox();
            this.ListaBrojeva = new System.Windows.Forms.ListBox();
            this.TimerProvjere = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvi broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drugi broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Treći broj:";
            // 
            // TxtPrviBroj
            // 
            this.TxtPrviBroj.Location = new System.Drawing.Point(68, 10);
            this.TxtPrviBroj.Name = "TxtPrviBroj";
            this.TxtPrviBroj.Size = new System.Drawing.Size(100, 20);
            this.TxtPrviBroj.TabIndex = 1;
            this.TxtPrviBroj.TextChanged += new System.EventHandler(this.TxtPrviBroj_TextChanged);
            // 
            // TxtDrugiBroj
            // 
            this.TxtDrugiBroj.Location = new System.Drawing.Point(68, 37);
            this.TxtDrugiBroj.Name = "TxtDrugiBroj";
            this.TxtDrugiBroj.Size = new System.Drawing.Size(100, 20);
            this.TxtDrugiBroj.TabIndex = 2;
            this.TxtDrugiBroj.TextChanged += new System.EventHandler(this.TxtDrugiBroj_TextChanged);
            // 
            // TxtTreciBroj
            // 
            this.TxtTreciBroj.Location = new System.Drawing.Point(68, 63);
            this.TxtTreciBroj.Name = "TxtTreciBroj";
            this.TxtTreciBroj.Size = new System.Drawing.Size(100, 20);
            this.TxtTreciBroj.TabIndex = 3;
            this.TxtTreciBroj.TextChanged += new System.EventHandler(this.TxtTreciBroj_TextChanged);
            // 
            // ListaBrojeva
            // 
            this.ListaBrojeva.FormattingEnabled = true;
            this.ListaBrojeva.Location = new System.Drawing.Point(13, 92);
            this.ListaBrojeva.Name = "ListaBrojeva";
            this.ListaBrojeva.Size = new System.Drawing.Size(155, 121);
            this.ListaBrojeva.TabIndex = 4;
            // 
            // TimerProvjere
            // 
            this.TimerProvjere.Enabled = true;
            this.TimerProvjere.Interval = 2500;
            this.TimerProvjere.Tick += new System.EventHandler(this.TimerProvjere_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 219);
            this.Controls.Add(this.ListaBrojeva);
            this.Controls.Add(this.TxtTreciBroj);
            this.Controls.Add(this.TxtDrugiBroj);
            this.Controls.Add(this.TxtPrviBroj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrviBroj;
        private System.Windows.Forms.TextBox TxtDrugiBroj;
        private System.Windows.Forms.TextBox TxtTreciBroj;
        private System.Windows.Forms.ListBox ListaBrojeva;
        private System.Windows.Forms.Timer TimerProvjere;
    }
}

