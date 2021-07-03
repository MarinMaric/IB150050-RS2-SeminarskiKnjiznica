
namespace Knjiznica.WinUI
{
    partial class frmClanovi
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
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.posudbeMax = new System.Windows.Forms.NumericUpDown();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.posudbeMin = new System.Windows.Forms.NumericUpDown();
            this.dtmOd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmDo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upozorenjaMax = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upozorenjaMin = new System.Windows.Forms.NumericUpDown();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUpozorenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPosudbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upozorenjaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upozorenjaMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ImePrezime,
            this.DatumRegistracije,
            this.Status,
            this.BrojUpozorenja,
            this.BrojPosudbi});
            this.dgvClanovi.Location = new System.Drawing.Point(310, 13);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanovi.Size = new System.Drawing.Size(393, 406);
            this.dgvClanovi.TabIndex = 0;
            this.dgvClanovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanovi_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPretraga);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.posudbeMax);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.posudbeMin);
            this.groupBox1.Controls.Add(this.dtmOd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtmDo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.upozorenjaMax);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.upozorenjaMin);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Ukloni filtere";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(54, 242);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 39;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "(max)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ime Prezime";
            // 
            // posudbeMax
            // 
            this.posudbeMax.Location = new System.Drawing.Point(198, 197);
            this.posudbeMax.Name = "posudbeMax";
            this.posudbeMax.Size = new System.Drawing.Size(45, 20);
            this.posudbeMax.TabIndex = 37;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(76, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "(min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registriran";
            // 
            // posudbeMin
            // 
            this.posudbeMin.Location = new System.Drawing.Point(99, 197);
            this.posudbeMin.Name = "posudbeMin";
            this.posudbeMin.Size = new System.Drawing.Size(45, 20);
            this.posudbeMin.TabIndex = 35;
            // 
            // dtmOd
            // 
            this.dtmOd.Location = new System.Drawing.Point(76, 55);
            this.dtmOd.Name = "dtmOd";
            this.dtmOd.Size = new System.Drawing.Size(200, 20);
            this.dtmOd.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Broj posudbi";
            // 
            // dtmDo
            // 
            this.dtmDo.Location = new System.Drawing.Point(76, 81);
            this.dtmDo.Name = "dtmDo";
            this.dtmDo.Size = new System.Drawing.Size(200, 20);
            this.dtmDo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "(max)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Status";
            // 
            // upozorenjaMax
            // 
            this.upozorenjaMax.Location = new System.Drawing.Point(198, 151);
            this.upozorenjaMax.Name = "upozorenjaMax";
            this.upozorenjaMax.Size = new System.Drawing.Size(45, 20);
            this.upozorenjaMax.TabIndex = 32;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(76, 107);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "(min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Broj upozorenja";
            // 
            // upozorenjaMin
            // 
            this.upozorenjaMin.Location = new System.Drawing.Point(99, 151);
            this.upozorenjaMin.Name = "upozorenjaMin";
            this.upozorenjaMin.Size = new System.Drawing.Size(45, 20);
            this.upozorenjaMin.TabIndex = 30;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(21, 396);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 40;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(220, 396);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 41;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // DatumRegistracije
            // 
            this.DatumRegistracije.DataPropertyName = "DatumUclanjivanja";
            this.DatumRegistracije.HeaderText = "Registriran";
            this.DatumRegistracije.Name = "DatumRegistracije";
            this.DatumRegistracije.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // BrojUpozorenja
            // 
            this.BrojUpozorenja.DataPropertyName = "BrojUpozorenja";
            this.BrojUpozorenja.HeaderText = "U";
            this.BrojUpozorenja.Name = "BrojUpozorenja";
            this.BrojUpozorenja.ReadOnly = true;
            this.BrojUpozorenja.Width = 25;
            // 
            // BrojPosudbi
            // 
            this.BrojPosudbi.DataPropertyName = "BrojPosudbi";
            this.BrojPosudbi.HeaderText = "P";
            this.BrojPosudbi.Name = "BrojPosudbi";
            this.BrojPosudbi.ReadOnly = true;
            this.BrojPosudbi.Width = 25;
            // 
            // frmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 431);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClanovi);
            this.Name = "frmClanovi";
            this.Text = "frmClanovi";
            this.Load += new System.EventHandler(this.frmClanovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upozorenjaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upozorenjaMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown posudbeMax;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown posudbeMin;
        private System.Windows.Forms.DateTimePicker dtmOd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upozorenjaMax;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown upozorenjaMin;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUpozorenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPosudbi;
    }
}