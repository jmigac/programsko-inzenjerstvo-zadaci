namespace Lab04G02
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
            this.LabelMinute = new System.Windows.Forms.Label();
            this.LabelMiliSekunde = new System.Windows.Forms.Label();
            this.LabelSekunde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnKrug = new System.Windows.Forms.Button();
            this.ListaVremenaKrugova = new System.Windows.Forms.ListBox();
            this.timerVremena = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelMinute
            // 
            this.LabelMinute.AutoSize = true;
            this.LabelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinute.Location = new System.Drawing.Point(12, 9);
            this.LabelMinute.Name = "LabelMinute";
            this.LabelMinute.Size = new System.Drawing.Size(55, 39);
            this.LabelMinute.TabIndex = 0;
            this.LabelMinute.Text = "00";
            // 
            // LabelMiliSekunde
            // 
            this.LabelMiliSekunde.AutoSize = true;
            this.LabelMiliSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiliSekunde.Location = new System.Drawing.Point(153, 9);
            this.LabelMiliSekunde.Name = "LabelMiliSekunde";
            this.LabelMiliSekunde.Size = new System.Drawing.Size(55, 39);
            this.LabelMiliSekunde.TabIndex = 0;
            this.LabelMiliSekunde.Text = "00";
            // 
            // LabelSekunde
            // 
            this.LabelSekunde.AutoSize = true;
            this.LabelSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSekunde.Location = new System.Drawing.Point(86, 9);
            this.LabelSekunde.Name = "LabelSekunde";
            this.LabelSekunde.Size = new System.Drawing.Size(55, 39);
            this.LabelSekunde.TabIndex = 0;
            this.LabelSekunde.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(20, 64);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(55, 38);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(78, 64);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(55, 38);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnKrug
            // 
            this.BtnKrug.Location = new System.Drawing.Point(139, 64);
            this.BtnKrug.Name = "BtnKrug";
            this.BtnKrug.Size = new System.Drawing.Size(55, 38);
            this.BtnKrug.TabIndex = 2;
            this.BtnKrug.Text = "Krug";
            this.BtnKrug.UseVisualStyleBackColor = true;
            this.BtnKrug.Click += new System.EventHandler(this.BtnKrug_Click);
            // 
            // ListaVremenaKrugova
            // 
            this.ListaVremenaKrugova.FormattingEnabled = true;
            this.ListaVremenaKrugova.Location = new System.Drawing.Point(12, 109);
            this.ListaVremenaKrugova.Name = "ListaVremenaKrugova";
            this.ListaVremenaKrugova.Size = new System.Drawing.Size(196, 147);
            this.ListaVremenaKrugova.TabIndex = 3;
            // 
            // timerVremena
            // 
            this.timerVremena.Enabled = true;
            this.timerVremena.Interval = 10;
            this.timerVremena.Tick += new System.EventHandler(this.timerVremena_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 272);
            this.Controls.Add(this.ListaVremenaKrugova);
            this.Controls.Add(this.BtnKrug);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelSekunde);
            this.Controls.Add(this.LabelMiliSekunde);
            this.Controls.Add(this.LabelMinute);
            this.Name = "Form1";
            this.Text = "Vrijeme krugova";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMinute;
        private System.Windows.Forms.Label LabelMiliSekunde;
        private System.Windows.Forms.Label LabelSekunde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnKrug;
        private System.Windows.Forms.ListBox ListaVremenaKrugova;
        private System.Windows.Forms.Timer timerVremena;
    }
}

