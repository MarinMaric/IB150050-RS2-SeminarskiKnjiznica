
namespace Knjiznica.WinUI
{
    partial class frmPosudbe
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
            this.Pretraga = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.brInput = new System.Windows.Forms.NumericUpDown();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.povratakDo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.povratakOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preuzimanjeDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.preuzimanjeOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrKopije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPreuzimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPovrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNova = new System.Windows.Forms.Button();
            this.Pretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // Pretraga
            // 
            this.Pretraga.Controls.Add(this.btnClear);
            this.Pretraga.Controls.Add(this.brInput);
            this.Pretraga.Controls.Add(this.checkDate);
            this.Pretraga.Controls.Add(this.povratakDo);
            this.Pretraga.Controls.Add(this.label5);
            this.Pretraga.Controls.Add(this.povratakOd);
            this.Pretraga.Controls.Add(this.label7);
            this.Pretraga.Controls.Add(this.label2);
            this.Pretraga.Controls.Add(this.preuzimanjeDo);
            this.Pretraga.Controls.Add(this.label4);
            this.Pretraga.Controls.Add(this.btnPretraga);
            this.Pretraga.Controls.Add(this.label6);
            this.Pretraga.Controls.Add(this.txtClan);
            this.Pretraga.Controls.Add(this.preuzimanjeOd);
            this.Pretraga.Controls.Add(this.label3);
            this.Pretraga.Controls.Add(this.label1);
            this.Pretraga.Controls.Add(this.txtNaslov);
            this.Pretraga.Location = new System.Drawing.Point(12, 12);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Size = new System.Drawing.Size(336, 296);
            this.Pretraga.TabIndex = 7;
            this.Pretraga.TabStop = false;
            this.Pretraga.Text = "Pretraga";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Ukloni filtere";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // brInput
            // 
            this.brInput.Location = new System.Drawing.Point(72, 81);
            this.brInput.Name = "brInput";
            this.brInput.Size = new System.Drawing.Size(244, 20);
            this.brInput.TabIndex = 33;
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDate.Location = new System.Drawing.Point(72, 212);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(94, 17);
            this.checkDate.TabIndex = 32;
            this.checkDate.Text = "Bilo koji period";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // povratakDo
            // 
            this.povratakDo.Enabled = false;
            this.povratakDo.Location = new System.Drawing.Point(72, 186);
            this.povratakDo.Name = "povratakDo";
            this.povratakDo.Size = new System.Drawing.Size(244, 20);
            this.povratakDo.TabIndex = 31;
            this.povratakDo.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "povratka";
            // 
            // povratakOd
            // 
            this.povratakOd.Enabled = false;
            this.povratakOd.Location = new System.Drawing.Point(72, 160);
            this.povratakOd.Name = "povratakOd";
            this.povratakOd.Size = new System.Drawing.Size(244, 20);
            this.povratakOd.TabIndex = 29;
            this.povratakOd.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Br. kopije";
            // 
            // preuzimanjeDo
            // 
            this.preuzimanjeDo.Enabled = false;
            this.preuzimanjeDo.Location = new System.Drawing.Point(72, 134);
            this.preuzimanjeDo.Name = "preuzimanjeDo";
            this.preuzimanjeDo.Size = new System.Drawing.Size(244, 20);
            this.preuzimanjeDo.TabIndex = 25;
            this.preuzimanjeDo.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "preuzeća";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(91, 258);
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
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Posudio";
            // 
            // txtClan
            // 
            this.txtClan.Location = new System.Drawing.Point(72, 55);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(244, 20);
            this.txtClan.TabIndex = 13;
            // 
            // preuzimanjeOd
            // 
            this.preuzimanjeOd.Enabled = false;
            this.preuzimanjeOd.Location = new System.Drawing.Point(72, 108);
            this.preuzimanjeOd.Name = "preuzimanjeOd";
            this.preuzimanjeOd.Size = new System.Drawing.Size(244, 20);
            this.preuzimanjeOd.TabIndex = 6;
            this.preuzimanjeOd.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPosudbe);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 425);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posudbe";
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.AllowUserToAddRows = false;
            this.dgvPosudbe.AllowUserToDeleteRows = false;
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.ImePrezime,
            this.BrKopije,
            this.DatumPreuzimanja,
            this.DatumPovrata});
            this.dgvPosudbe.Location = new System.Drawing.Point(3, 16);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.ReadOnly = true;
            this.dgvPosudbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudbe.Size = new System.Drawing.Size(544, 403);
            this.dgvPosudbe.TabIndex = 0;
            this.dgvPosudbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ClanIme";
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // BrKopije
            // 
            this.BrKopije.DataPropertyName = "BrojKopije";
            this.BrKopije.HeaderText = "Broj kopije";
            this.BrKopije.Name = "BrKopije";
            this.BrKopije.ReadOnly = true;
            // 
            // DatumPreuzimanja
            // 
            this.DatumPreuzimanja.DataPropertyName = "DatumPreuzeca";
            this.DatumPreuzimanja.HeaderText = "Preuzeto";
            this.DatumPreuzimanja.Name = "DatumPreuzimanja";
            this.DatumPreuzimanja.ReadOnly = true;
            // 
            // DatumPovrata
            // 
            this.DatumPovrata.DataPropertyName = "DatumPovrata";
            this.DatumPovrata.HeaderText = "Vraćeno";
            this.DatumPovrata.Name = "DatumPovrata";
            this.DatumPovrata.ReadOnly = true;
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(12, 408);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(106, 23);
            this.btnNova.TabIndex = 32;
            this.btnNova.Text = "Nova posudba";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // frmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 452);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.Pretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPosudbe";
            this.Text = "frmPosudbe";
            this.Pretraga.ResumeLayout(false);
            this.Pretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pretraga;
        private System.Windows.Forms.DateTimePicker preuzimanjeDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.DateTimePicker preuzimanjeOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.DateTimePicker povratakDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker povratakOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrKopije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPreuzimanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPovrata;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.NumericUpDown brInput;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.Button btnClear;
    }
}