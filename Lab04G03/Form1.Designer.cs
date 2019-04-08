namespace Lab04G03
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
            this.BtnSortBojaSpol = new System.Windows.Forms.Button();
            this.BtnSortSpol = new System.Windows.Forms.Button();
            this.BtnSortBoja = new System.Windows.Forms.Button();
            this.BtnDodajGovedo = new System.Windows.Forms.Button();
            this.ComboBoja = new System.Windows.Forms.ComboBox();
            this.ComboSpol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNazivGoveda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaIspisaGoveda = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSortBojaSpol);
            this.groupBox1.Controls.Add(this.BtnSortSpol);
            this.groupBox1.Controls.Add(this.BtnSortBoja);
            this.groupBox1.Controls.Add(this.BtnDodajGovedo);
            this.groupBox1.Controls.Add(this.ComboBoja);
            this.groupBox1.Controls.Add(this.ComboSpol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNazivGoveda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje goveda";
            // 
            // BtnSortBojaSpol
            // 
            this.BtnSortBojaSpol.Location = new System.Drawing.Point(15, 165);
            this.BtnSortBojaSpol.Name = "BtnSortBojaSpol";
            this.BtnSortBojaSpol.Size = new System.Drawing.Size(237, 51);
            this.BtnSortBojaSpol.TabIndex = 3;
            this.BtnSortBojaSpol.Text = "Sortiraj po boji i spolu";
            this.BtnSortBojaSpol.UseVisualStyleBackColor = true;
            this.BtnSortBojaSpol.Click += new System.EventHandler(this.BtnSortBojaSpol_Click);
            // 
            // BtnSortSpol
            // 
            this.BtnSortSpol.Location = new System.Drawing.Point(177, 108);
            this.BtnSortSpol.Name = "BtnSortSpol";
            this.BtnSortSpol.Size = new System.Drawing.Size(75, 51);
            this.BtnSortSpol.TabIndex = 3;
            this.BtnSortSpol.Text = "Sortiraj po spolu";
            this.BtnSortSpol.UseVisualStyleBackColor = true;
            this.BtnSortSpol.Click += new System.EventHandler(this.BtnSortSpol_Click);
            // 
            // BtnSortBoja
            // 
            this.BtnSortBoja.Location = new System.Drawing.Point(96, 108);
            this.BtnSortBoja.Name = "BtnSortBoja";
            this.BtnSortBoja.Size = new System.Drawing.Size(75, 51);
            this.BtnSortBoja.TabIndex = 3;
            this.BtnSortBoja.Text = "Sortiraj po boji";
            this.BtnSortBoja.UseVisualStyleBackColor = true;
            this.BtnSortBoja.Click += new System.EventHandler(this.BtnSortBoja_Click);
            // 
            // BtnDodajGovedo
            // 
            this.BtnDodajGovedo.Location = new System.Drawing.Point(15, 108);
            this.BtnDodajGovedo.Name = "BtnDodajGovedo";
            this.BtnDodajGovedo.Size = new System.Drawing.Size(75, 51);
            this.BtnDodajGovedo.TabIndex = 3;
            this.BtnDodajGovedo.Text = "Dodaj govedo";
            this.BtnDodajGovedo.UseVisualStyleBackColor = true;
            this.BtnDodajGovedo.Click += new System.EventHandler(this.BtnDodajGovedo_Click);
            // 
            // ComboBoja
            // 
            this.ComboBoja.FormattingEnabled = true;
            this.ComboBoja.Items.AddRange(new object[] {
            "Smeda",
            "Crna",
            "Bijela"});
            this.ComboBoja.Location = new System.Drawing.Point(47, 76);
            this.ComboBoja.Name = "ComboBoja";
            this.ComboBoja.Size = new System.Drawing.Size(213, 21);
            this.ComboBoja.TabIndex = 2;
            // 
            // ComboSpol
            // 
            this.ComboSpol.FormattingEnabled = true;
            this.ComboSpol.Items.AddRange(new object[] {
            "Musko",
            "Zensko",
            "Nedefinirano"});
            this.ComboSpol.Location = new System.Drawing.Point(47, 47);
            this.ComboSpol.Name = "ComboSpol";
            this.ComboSpol.Size = new System.Drawing.Size(213, 21);
            this.ComboSpol.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Boja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spol:";
            // 
            // TxtNazivGoveda
            // 
            this.TxtNazivGoveda.Location = new System.Drawing.Point(47, 17);
            this.TxtNazivGoveda.Name = "TxtNazivGoveda";
            this.TxtNazivGoveda.Size = new System.Drawing.Size(213, 20);
            this.TxtNazivGoveda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // ListaIspisaGoveda
            // 
            this.ListaIspisaGoveda.FormattingEnabled = true;
            this.ListaIspisaGoveda.Location = new System.Drawing.Point(15, 240);
            this.ListaIspisaGoveda.Name = "ListaIspisaGoveda";
            this.ListaIspisaGoveda.Size = new System.Drawing.Size(266, 303);
            this.ListaIspisaGoveda.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 555);
            this.Controls.Add(this.ListaIspisaGoveda);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoja;
        private System.Windows.Forms.ComboBox ComboSpol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNazivGoveda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSortSpol;
        private System.Windows.Forms.Button BtnSortBoja;
        private System.Windows.Forms.Button BtnDodajGovedo;
        private System.Windows.Forms.ListBox ListaIspisaGoveda;
        private System.Windows.Forms.Button BtnSortBojaSpol;
    }
}

