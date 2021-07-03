
namespace Knjiznica.WinUI
{
    partial class frmKazne
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
            this.dgvKazne = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.numIznos = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaceno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKazne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKazne
            // 
            this.dgvKazne.AllowUserToAddRows = false;
            this.dgvKazne.AllowUserToDeleteRows = false;
            this.dgvKazne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKazne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Iznos,
            this.Placeno});
            this.dgvKazne.Location = new System.Drawing.Point(277, 12);
            this.dgvKazne.Name = "dgvKazne";
            this.dgvKazne.ReadOnly = true;
            this.dgvKazne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKazne.Size = new System.Drawing.Size(185, 404);
            this.dgvKazne.TabIndex = 0;
            this.dgvKazne.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKazne_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Iznos";
            // 
            // numIznos
            // 
            this.numIznos.Location = new System.Drawing.Point(61, 30);
            this.numIznos.Name = "numIznos";
            this.numIznos.Size = new System.Drawing.Size(200, 20);
            this.numIznos.TabIndex = 42;
            // 
            // cmbPlaceno
            // 
            this.cmbPlaceno.FormattingEnabled = true;
            this.cmbPlaceno.Location = new System.Drawing.Point(61, 56);
            this.cmbPlaceno.Name = "cmbPlaceno";
            this.cmbPlaceno.Size = new System.Drawing.Size(200, 21);
            this.cmbPlaceno.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Plaćeno";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(96, 103);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 45;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Width = 70;
            // 
            // Placeno
            // 
            this.Placeno.DataPropertyName = "Placeno";
            this.Placeno.HeaderText = "Plaćeno";
            this.Placeno.Name = "Placeno";
            this.Placeno.ReadOnly = true;
            this.Placeno.Width = 70;
            // 
            // frmKazne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 430);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlaceno);
            this.Controls.Add(this.numIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKazne);
            this.Name = "frmKazne";
            this.Text = "frmKazne";
            this.Load += new System.EventHandler(this.frmKazne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKazne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKazne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numIznos;
        private System.Windows.Forms.ComboBox cmbPlaceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placeno;
    }
}