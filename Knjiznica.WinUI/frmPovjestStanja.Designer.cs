
namespace Knjiznica.WinUI
{
    partial class frmPovjestStanja
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
            this.dgvStanja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmBiljezenja = new System.Windows.Forms.DateTimePicker();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlasnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanja
            // 
            this.dgvStanja.AllowUserToAddRows = false;
            this.dgvStanja.AllowUserToDeleteRows = false;
            this.dgvStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Vlasnik,
            this.Datum});
            this.dgvStanja.Location = new System.Drawing.Point(214, 12);
            this.dgvStanja.Name = "dgvStanja";
            this.dgvStanja.ReadOnly = true;
            this.dgvStanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStanja.Size = new System.Drawing.Size(219, 393);
            this.dgvStanja.TabIndex = 0;
            this.dgvStanja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStanja_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime i prezime člana";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(30, 54);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(143, 20);
            this.txtIme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum bilježenja";
            // 
            // dtmBiljezenja
            // 
            this.dtmBiljezenja.Location = new System.Drawing.Point(30, 129);
            this.dtmBiljezenja.Name = "dtmBiljezenja";
            this.dtmBiljezenja.Size = new System.Drawing.Size(143, 20);
            this.dtmBiljezenja.TabIndex = 4;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(30, 185);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(30, 382);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 7;
            this.btnIzbrisi.Text = "Izbriši";
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
            // Vlasnik
            // 
            this.Vlasnik.DataPropertyName = "Vlasnik";
            this.Vlasnik.HeaderText = "Clan";
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumBiljezenja";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // frmPovjestStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 424);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dtmBiljezenja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStanja);
            this.Name = "frmPovjestStanja";
            this.Text = "frmPovjestStanja";
            this.Load += new System.EventHandler(this.frmPovjestStanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmBiljezenja;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlasnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}