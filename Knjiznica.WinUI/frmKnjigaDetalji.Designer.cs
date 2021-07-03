
namespace Knjiznica.WinUI
{
    partial class frmKnjigaDetalji
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
            this.slika = new System.Windows.Forms.PictureBox();
            this.txtNaslov = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzbrisiKopiju = new System.Windows.Forms.Button();
            this.txtKopija = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvKopije = new System.Windows.Forms.DataGridView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKopije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKopije)).BeginInit();
            this.SuspendLayout();
            // 
            // slika
            // 
            this.slika.Location = new System.Drawing.Point(312, 33);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(129, 167);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 1;
            this.slika.TabStop = false;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(15, 33);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(262, 81);
            this.txtNaslov.TabIndex = 2;
            this.txtNaslov.Text = "Naslov";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(26, 116);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(239, 21);
            this.txtAutor.TabIndex = 3;
            this.txtAutor.Text = "Autor";
            this.txtAutor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(26, 169);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(219, 225);
            this.txtOpis.TabIndex = 4;
            this.txtOpis.Text = "Opis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Location = new System.Drawing.Point(267, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kopije";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPretraga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnIzbrisiKopiju);
            this.groupBox2.Controls.Add(this.txtKopija);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(22, 71);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Prikaži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Kopije";
            // 
            // btnIzbrisiKopiju
            // 
            this.btnIzbrisiKopiju.Location = new System.Drawing.Point(103, 71);
            this.btnIzbrisiKopiju.Name = "btnIzbrisiKopiju";
            this.btnIzbrisiKopiju.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiKopiju.TabIndex = 1;
            this.btnIzbrisiKopiju.Text = "Izbrisi";
            this.btnIzbrisiKopiju.UseVisualStyleBackColor = true;
            this.btnIzbrisiKopiju.Click += new System.EventHandler(this.btnIzbrisiKopiju_Click);
            // 
            // txtKopija
            // 
            this.txtKopija.Location = new System.Drawing.Point(75, 31);
            this.txtKopija.Name = "txtKopija";
            this.txtKopija.Size = new System.Drawing.Size(83, 20);
            this.txtKopija.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(119, 184);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvKopije
            // 
            this.dgvKopije.AllowUserToAddRows = false;
            this.dgvKopije.AllowUserToDeleteRows = false;
            this.dgvKopije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKopije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BrojKopije});
            this.dgvKopije.Location = new System.Drawing.Point(490, 33);
            this.dgvKopije.Name = "dgvKopije";
            this.dgvKopije.ReadOnly = true;
            this.dgvKopije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKopije.Size = new System.Drawing.Size(144, 406);
            this.dgvKopije.TabIndex = 0;
            this.dgvKopije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKopije_CellDoubleClick);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(29, 406);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi knjigu";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(130, 406);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "Izbriši knjigu";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // BrojKopije
            // 
            this.BrojKopije.DataPropertyName = "BrojKopije";
            this.BrojKopije.HeaderText = "ID Kopije";
            this.BrojKopije.Name = "BrojKopije";
            this.BrojKopije.ReadOnly = true;
            // 
            // frmKnjigaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 451);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKopije);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.slika);
            this.Name = "frmKnjigaDetalji";
            this.Text = "Detalji knjige";
            this.Load += new System.EventHandler(this.frmKnjigaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKopije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.Label txtAutor;
        private System.Windows.Forms.Label txtOpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKopije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKopija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisiKopiju;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKopije;
    }
}