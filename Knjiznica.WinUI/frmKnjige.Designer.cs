
namespace Knjiznica.WinUI
{
    partial class frmKnjige
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
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.Pretraga = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUkupnoMin = new System.Windows.Forms.TextBox();
            this.txtUkupnoMax = new System.Windows.Forms.TextBox();
            this.txtDostupnoMin = new System.Windows.Forms.TextBox();
            this.txtDostupnoMax = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.BrStranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.Pretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKnjige);
            this.groupBox1.Location = new System.Drawing.Point(364, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Knjige";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AllowUserToAddRows = false;
            this.dgvKnjige.AllowUserToDeleteRows = false;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.Autor,
            this.Dostupno,
            this.Ukupno,
            this.BrStranica});
            this.dgvKnjige.Location = new System.Drawing.Point(3, 16);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(537, 403);
            this.dgvKnjige.TabIndex = 0;
            this.dgvKnjige.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKnjige_CellDoubleClick);
            // 
            // Pretraga
            // 
            this.Pretraga.Controls.Add(this.btnPretraga);
            this.Pretraga.Controls.Add(this.txtDostupnoMax);
            this.Pretraga.Controls.Add(this.txtDostupnoMin);
            this.Pretraga.Controls.Add(this.txtUkupnoMax);
            this.Pretraga.Controls.Add(this.txtUkupnoMin);
            this.Pretraga.Controls.Add(this.label8);
            this.Pretraga.Controls.Add(this.label7);
            this.Pretraga.Controls.Add(this.label6);
            this.Pretraga.Controls.Add(this.txtAutor);
            this.Pretraga.Controls.Add(this.cmbKategorija);
            this.Pretraga.Controls.Add(this.label5);
            this.Pretraga.Controls.Add(this.txtMax);
            this.Pretraga.Controls.Add(this.label4);
            this.Pretraga.Controls.Add(this.txtMin);
            this.Pretraga.Controls.Add(this.label2);
            this.Pretraga.Controls.Add(this.txtISBN);
            this.Pretraga.Controls.Add(this.label1);
            this.Pretraga.Controls.Add(this.txtNaslov);
            this.Pretraga.Location = new System.Drawing.Point(12, 13);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Size = new System.Drawing.Size(336, 248);
            this.Pretraga.TabIndex = 1;
            this.Pretraga.TabStop = false;
            this.Pretraga.Text = "Pretraga";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(127, 217);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 23;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(72, 55);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(244, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(72, 28);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(244, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(273, 396);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(70, 112);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(90, 20);
            this.txtISBN.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(232, 112);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(38, 20);
            this.txtMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Br. stranica";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(276, 112);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(38, 20);
            this.txtMax.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Br. dostupnih kopija";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Br. kopija ukupno";
            // 
            // txtUkupnoMin
            // 
            this.txtUkupnoMin.Location = new System.Drawing.Point(188, 166);
            this.txtUkupnoMin.Name = "txtUkupnoMin";
            this.txtUkupnoMin.Size = new System.Drawing.Size(38, 20);
            this.txtUkupnoMin.TabIndex = 19;
            // 
            // txtUkupnoMax
            // 
            this.txtUkupnoMax.Location = new System.Drawing.Point(232, 166);
            this.txtUkupnoMax.Name = "txtUkupnoMax";
            this.txtUkupnoMax.Size = new System.Drawing.Size(38, 20);
            this.txtUkupnoMax.TabIndex = 20;
            // 
            // txtDostupnoMin
            // 
            this.txtDostupnoMin.Location = new System.Drawing.Point(26, 166);
            this.txtDostupnoMin.Name = "txtDostupnoMin";
            this.txtDostupnoMin.Size = new System.Drawing.Size(38, 20);
            this.txtDostupnoMin.TabIndex = 21;
            // 
            // txtDostupnoMax
            // 
            this.txtDostupnoMax.Location = new System.Drawing.Point(70, 166);
            this.txtDostupnoMax.Name = "txtDostupnoMax";
            this.txtDostupnoMax.Size = new System.Drawing.Size(38, 20);
            this.txtDostupnoMax.TabIndex = 22;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(72, 81);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(244, 21);
            this.cmbKategorija.TabIndex = 12;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 396);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj knjigu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(12, 367);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(75, 23);
            this.btnPosudi.TabIndex = 4;
            this.btnPosudi.Text = "Posudi knjigu";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // BrStranica
            // 
            this.BrStranica.DataPropertyName = "BrojStranica";
            this.BrStranica.HeaderText = "Br. stranica";
            this.BrStranica.Name = "BrStranica";
            this.BrStranica.ReadOnly = true;
            // 
            // Ukupno
            // 
            this.Ukupno.DataPropertyName = "BrojKopija";
            this.Ukupno.HeaderText = "Ukupno";
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.ReadOnly = true;
            // 
            // Dostupno
            // 
            this.Dostupno.DataPropertyName = "BrojDostupnihKopija";
            this.Dostupno.HeaderText = "Dostupno";
            this.Dostupno.Name = "Dostupno";
            this.Dostupno.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 446);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.Pretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKnjige";
            this.Text = "frmKnjige";
            this.Load += new System.EventHandler(this.frmKnjige_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.Pretraga.ResumeLayout(false);
            this.Pretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.GroupBox Pretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.TextBox txtDostupnoMax;
        private System.Windows.Forms.TextBox txtDostupnoMin;
        private System.Windows.Forms.TextBox txtUkupnoMax;
        private System.Windows.Forms.TextBox txtUkupnoMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrStranica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPosudi;
    }
}