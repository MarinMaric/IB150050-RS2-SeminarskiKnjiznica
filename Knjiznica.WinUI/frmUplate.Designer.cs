
namespace Knjiznica.WinUI
{
    partial class frmUplate
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
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.Pretraga = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtmDo = new System.Windows.Forms.DateTimePicker();
            this.dtmOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplacivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosMin = new System.Windows.Forms.NumericUpDown();
            this.iznosMax = new System.Windows.Forms.NumericUpDown();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.Pretraga.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznosMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznosMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(273, 408);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // Pretraga
            // 
            this.Pretraga.Controls.Add(this.checkDate);
            this.Pretraga.Controls.Add(this.iznosMax);
            this.Pretraga.Controls.Add(this.iznosMin);
            this.Pretraga.Controls.Add(this.btnClear);
            this.Pretraga.Controls.Add(this.dtmDo);
            this.Pretraga.Controls.Add(this.dtmOd);
            this.Pretraga.Controls.Add(this.label3);
            this.Pretraga.Controls.Add(this.btnPretraga);
            this.Pretraga.Controls.Add(this.label6);
            this.Pretraga.Controls.Add(this.txtOpis);
            this.Pretraga.Controls.Add(this.label5);
            this.Pretraga.Controls.Add(this.label2);
            this.Pretraga.Controls.Add(this.label1);
            this.Pretraga.Controls.Add(this.txtIme);
            this.Pretraga.Location = new System.Drawing.Point(12, 12);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Size = new System.Drawing.Size(336, 248);
            this.Pretraga.TabIndex = 5;
            this.Pretraga.TabStop = false;
            this.Pretraga.Text = "Pretraga";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Ukloni filtere";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtmDo
            // 
            this.dtmDo.Enabled = false;
            this.dtmDo.Location = new System.Drawing.Point(90, 135);
            this.dtmDo.Name = "dtmDo";
            this.dtmDo.Size = new System.Drawing.Size(226, 20);
            this.dtmDo.TabIndex = 28;
            this.dtmDo.Value = new System.DateTime(2021, 6, 23, 22, 54, 32, 0);
            // 
            // dtmOd
            // 
            this.dtmOd.Enabled = false;
            this.dtmOd.Location = new System.Drawing.Point(90, 109);
            this.dtmOd.Name = "dtmOd";
            this.dtmOd.Size = new System.Drawing.Size(226, 20);
            this.dtmOd.TabIndex = 27;
            this.dtmOd.Value = new System.DateTime(2021, 6, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Datum do";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(84, 219);
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
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(90, 55);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(226, 20);
            this.txtOpis.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Iznos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum od";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(90, 28);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(226, 20);
            this.txtIme.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKnjige);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uplate";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AllowUserToAddRows = false;
            this.dgvKnjige.AllowUserToDeleteRows = false;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Clan,
            this.Opis,
            this.Iznos,
            this.DatumUplacivanja});
            this.dgvKnjige.Location = new System.Drawing.Point(3, 16);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(445, 403);
            this.dgvKnjige.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Clan
            // 
            this.Clan.DataPropertyName = "ClanIme";
            this.Clan.HeaderText = "Član";
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // DatumUplacivanja
            // 
            this.DatumUplacivanja.DataPropertyName = "DatumUplacivanja";
            this.DatumUplacivanja.HeaderText = "Datum uplate";
            this.DatumUplacivanja.Name = "DatumUplacivanja";
            this.DatumUplacivanja.ReadOnly = true;
            // 
            // iznosMin
            // 
            this.iznosMin.Location = new System.Drawing.Point(90, 82);
            this.iznosMin.Name = "iznosMin";
            this.iznosMin.Size = new System.Drawing.Size(114, 20);
            this.iznosMin.TabIndex = 30;
            // 
            // iznosMax
            // 
            this.iznosMax.Location = new System.Drawing.Point(210, 82);
            this.iznosMax.Name = "iznosMax";
            this.iznosMax.Size = new System.Drawing.Size(106, 20);
            this.iznosMax.TabIndex = 31;
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDate.Location = new System.Drawing.Point(90, 161);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(94, 17);
            this.checkDate.TabIndex = 7;
            this.checkDate.Text = "Bilo koji period";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // frmUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.Pretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUplate";
            this.Text = "frmUplate";
            this.Load += new System.EventHandler(this.frmUplate_Load);
            this.Pretraga.ResumeLayout(false);
            this.Pretraga.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznosMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznosMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.GroupBox Pretraga;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtmDo;
        private System.Windows.Forms.DateTimePicker dtmOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplacivanja;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.NumericUpDown iznosMax;
        private System.Windows.Forms.NumericUpDown iznosMin;
    }
}