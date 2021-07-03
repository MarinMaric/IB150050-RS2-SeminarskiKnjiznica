
namespace Knjiznica.WinUI
{
    partial class frmKazna
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Naslov = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.Datum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(415, 336);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(75, 79);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(415, 238);
            this.txtPoruka.TabIndex = 8;
            this.txtPoruka.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Poruka";
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(18, 32);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(32, 13);
            this.Naslov.TabIndex = 6;
            this.Naslov.Text = "Iznos";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(75, 32);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(104, 20);
            this.numInput.TabIndex = 10;
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(290, 32);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(200, 20);
            this.inputDatum.TabIndex = 11;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(246, 32);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 12;
            this.Datum.Text = "Datum";
            // 
            // frmKazna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 376);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naslov);
            this.Name = "frmKazna";
            this.Text = "frmKazna";
            this.Load += new System.EventHandler(this.frmKazna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Label Datum;
    }
}