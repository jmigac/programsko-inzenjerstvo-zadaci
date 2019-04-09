namespace Zadatak117
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
            this.ListaSvihKnjiga = new System.Windows.Forms.ListBox();
            this.ListaSlobodnihKnjiga = new System.Windows.Forms.ListBox();
            this.ListaIznajmljenihKnjiga = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNazivKnjige = new System.Windows.Forms.TextBox();
            this.BtnUnosKnjige = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNaziv = new System.Windows.Forms.TextBox();
            this.RadioIznajmi = new System.Windows.Forms.RadioButton();
            this.RadioSlobodna = new System.Windows.Forms.RadioButton();
            this.BtnIzmjeniStatus = new System.Windows.Forms.Button();
            this.VremenskoAžuriranjeLista = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaSvihKnjiga
            // 
            this.ListaSvihKnjiga.FormattingEnabled = true;
            this.ListaSvihKnjiga.Location = new System.Drawing.Point(278, 25);
            this.ListaSvihKnjiga.Name = "ListaSvihKnjiga";
            this.ListaSvihKnjiga.Size = new System.Drawing.Size(120, 225);
            this.ListaSvihKnjiga.TabIndex = 0;
            // 
            // ListaSlobodnihKnjiga
            // 
            this.ListaSlobodnihKnjiga.FormattingEnabled = true;
            this.ListaSlobodnihKnjiga.Location = new System.Drawing.Point(404, 25);
            this.ListaSlobodnihKnjiga.Name = "ListaSlobodnihKnjiga";
            this.ListaSlobodnihKnjiga.Size = new System.Drawing.Size(120, 225);
            this.ListaSlobodnihKnjiga.TabIndex = 0;
            // 
            // ListaIznajmljenihKnjiga
            // 
            this.ListaIznajmljenihKnjiga.FormattingEnabled = true;
            this.ListaIznajmljenihKnjiga.Location = new System.Drawing.Point(530, 25);
            this.ListaIznajmljenihKnjiga.Name = "ListaIznajmljenihKnjiga";
            this.ListaIznajmljenihKnjiga.Size = new System.Drawing.Size(120, 225);
            this.ListaIznajmljenihKnjiga.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUnosKnjige);
            this.groupBox1.Controls.Add(this.TxtNazivKnjige);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos knjige";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv knjige:";
            // 
            // TxtNazivKnjige
            // 
            this.TxtNazivKnjige.Location = new System.Drawing.Point(10, 37);
            this.TxtNazivKnjige.Name = "TxtNazivKnjige";
            this.TxtNazivKnjige.Size = new System.Drawing.Size(243, 20);
            this.TxtNazivKnjige.TabIndex = 1;
            // 
            // BtnUnosKnjige
            // 
            this.BtnUnosKnjige.Location = new System.Drawing.Point(10, 64);
            this.BtnUnosKnjige.Name = "BtnUnosKnjige";
            this.BtnUnosKnjige.Size = new System.Drawing.Size(243, 23);
            this.BtnUnosKnjige.TabIndex = 2;
            this.BtnUnosKnjige.Text = "Unos knjige";
            this.BtnUnosKnjige.UseVisualStyleBackColor = true;
            this.BtnUnosKnjige.Click += new System.EventHandler(this.BtnUnosKnjige_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnIzmjeniStatus);
            this.groupBox2.Controls.Add(this.RadioSlobodna);
            this.groupBox2.Controls.Add(this.RadioIznajmi);
            this.groupBox2.Controls.Add(this.TxtNaziv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promjeni status knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv knjige:";
            // 
            // TxtNaziv
            // 
            this.TxtNaziv.Location = new System.Drawing.Point(10, 34);
            this.TxtNaziv.Name = "TxtNaziv";
            this.TxtNaziv.Size = new System.Drawing.Size(243, 20);
            this.TxtNaziv.TabIndex = 1;
            // 
            // RadioIznajmi
            // 
            this.RadioIznajmi.AutoSize = true;
            this.RadioIznajmi.Location = new System.Drawing.Point(10, 61);
            this.RadioIznajmi.Name = "RadioIznajmi";
            this.RadioIznajmi.Size = new System.Drawing.Size(57, 17);
            this.RadioIznajmi.TabIndex = 2;
            this.RadioIznajmi.Text = "Iznajmi";
            this.RadioIznajmi.UseVisualStyleBackColor = true;
            // 
            // RadioSlobodna
            // 
            this.RadioSlobodna.AutoSize = true;
            this.RadioSlobodna.Location = new System.Drawing.Point(102, 61);
            this.RadioSlobodna.Name = "RadioSlobodna";
            this.RadioSlobodna.Size = new System.Drawing.Size(68, 17);
            this.RadioSlobodna.TabIndex = 3;
            this.RadioSlobodna.Text = "slobodna";
            this.RadioSlobodna.UseVisualStyleBackColor = true;
            // 
            // BtnIzmjeniStatus
            // 
            this.BtnIzmjeniStatus.Location = new System.Drawing.Point(10, 84);
            this.BtnIzmjeniStatus.Name = "BtnIzmjeniStatus";
            this.BtnIzmjeniStatus.Size = new System.Drawing.Size(243, 23);
            this.BtnIzmjeniStatus.TabIndex = 2;
            this.BtnIzmjeniStatus.Text = "Izmjeni status";
            this.BtnIzmjeniStatus.UseVisualStyleBackColor = true;
            this.BtnIzmjeniStatus.Click += new System.EventHandler(this.BtnIzmjeniStatus_Click);
            // 
            // VremenskoAžuriranjeLista
            // 
            this.VremenskoAžuriranjeLista.Enabled = true;
            this.VremenskoAžuriranjeLista.Interval = 3000;
            this.VremenskoAžuriranjeLista.Tick += new System.EventHandler(this.VremenskoAžuriranjeLista_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sve knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slobodne knjige";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Iznajmljene knjige";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListaIznajmljenihKnjiga);
            this.Controls.Add(this.ListaSlobodnihKnjiga);
            this.Controls.Add(this.ListaSvihKnjiga);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "IS Knjižničara";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaSvihKnjiga;
        private System.Windows.Forms.ListBox ListaSlobodnihKnjiga;
        private System.Windows.Forms.ListBox ListaIznajmljenihKnjiga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnUnosKnjige;
        private System.Windows.Forms.TextBox TxtNazivKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnIzmjeniStatus;
        private System.Windows.Forms.RadioButton RadioSlobodna;
        private System.Windows.Forms.RadioButton RadioIznajmi;
        private System.Windows.Forms.TextBox TxtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer VremenskoAžuriranjeLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

