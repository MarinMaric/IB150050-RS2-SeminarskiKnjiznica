
namespace Knjiznica.WinUI
{
    partial class frmStanjeDetalji
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
            this.txtClan = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClan
            // 
            this.txtClan.AutoSize = true;
            this.txtClan.Location = new System.Drawing.Point(27, 31);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(100, 13);
            this.txtClan.TabIndex = 2;
            this.txtClan.Text = "Ime i prezime člana:";
            // 
            // txtDatum
            // 
            this.txtDatum.AutoSize = true;
            this.txtDatum.Location = new System.Drawing.Point(27, 58);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(90, 13);
            this.txtDatum.TabIndex = 3;
            this.txtDatum.Text = "Datum bilježenja: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Opis: ";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(30, 114);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(299, 173);
            this.txtOpis.TabIndex = 5;
            this.txtOpis.Text = "";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(87, 311);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(179, 311);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 7;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // frmStanjeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 346);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtClan);
            this.Name = "frmStanjeDetalji";
            this.Text = "frmStanjeDetalji";
            this.Load += new System.EventHandler(this.frmStanjeDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtClan;
        private System.Windows.Forms.Label txtDatum;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}