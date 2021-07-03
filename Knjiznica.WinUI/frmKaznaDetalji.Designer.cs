
namespace Knjiznica.WinUI
{
    partial class frmKaznaDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlaceno = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.Label();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Naslov = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Plaćeno";
            // 
            // cmbPlaceno
            // 
            this.cmbPlaceno.FormattingEnabled = true;
            this.cmbPlaceno.Location = new System.Drawing.Point(68, 50);
            this.cmbPlaceno.Name = "cmbPlaceno";
            this.cmbPlaceno.Size = new System.Drawing.Size(294, 21);
            this.cmbPlaceno.TabIndex = 45;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(11, 86);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 53;
            this.Datum.Text = "Datum";
            // 
            // inputDatum
            // 
            this.inputDatum.Enabled = false;
            this.inputDatum.Location = new System.Drawing.Point(68, 80);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(294, 20);
            this.inputDatum.TabIndex = 52;
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(68, 22);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(294, 20);
            this.numInput.TabIndex = 51;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(405, 489);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 50;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(68, 117);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(294, 238);
            this.txtPoruka.TabIndex = 49;
            this.txtPoruka.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Poruka";
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(11, 22);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(32, 13);
            this.Naslov.TabIndex = 47;
            this.Naslov.Text = "Iznos";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmKaznaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 425);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlaceno);
            this.Name = "frmKaznaDetalji";
            this.Text = "frmKaznaDetalji";
            this.Load += new System.EventHandler(this.frmKaznaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlaceno;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Button btnSave;
    }
}