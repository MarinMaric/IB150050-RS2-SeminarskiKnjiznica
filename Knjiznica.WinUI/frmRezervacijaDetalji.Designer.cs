
namespace Knjiznica.WinUI
{
    partial class frmRezervacijaDetalji
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
            this.Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.Label();
            this.dtmRezervacije = new System.Windows.Forms.Label();
            this.dtmIsteka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(103, 187);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 62;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(24, 77);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 13);
            this.Email.TabIndex = 56;
            this.Email.Text = "Podneseno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Rezervirao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(103, 129);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(164, 21);
            this.cmbStatus.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ističe:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Location = new System.Drawing.Point(100, 25);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(43, 13);
            this.txtNaslov.TabIndex = 64;
            this.txtNaslov.Text = "Naslov:";
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.Location = new System.Drawing.Point(100, 51);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(43, 13);
            this.txtIme.TabIndex = 65;
            this.txtIme.Text = "Naslov:";
            // 
            // dtmRezervacije
            // 
            this.dtmRezervacije.AutoSize = true;
            this.dtmRezervacije.Location = new System.Drawing.Point(100, 77);
            this.dtmRezervacije.Name = "dtmRezervacije";
            this.dtmRezervacije.Size = new System.Drawing.Size(43, 13);
            this.dtmRezervacije.TabIndex = 66;
            this.dtmRezervacije.Text = "Naslov:";
            // 
            // dtmIsteka
            // 
            this.dtmIsteka.AutoSize = true;
            this.dtmIsteka.Location = new System.Drawing.Point(100, 104);
            this.dtmIsteka.Name = "dtmIsteka";
            this.dtmIsteka.Size = new System.Drawing.Size(43, 13);
            this.dtmIsteka.TabIndex = 67;
            this.dtmIsteka.Text = "Naslov:";
            // 
            // frmRezervacijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 227);
            this.Controls.Add(this.dtmIsteka);
            this.Controls.Add(this.dtmRezervacije);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Name = "frmRezervacijaDetalji";
            this.Text = "frmRezervacijaDetalji";
            this.Load += new System.EventHandler(this.frmRezervacijaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.Label txtIme;
        private System.Windows.Forms.Label dtmRezervacije;
        private System.Windows.Forms.Label dtmIsteka;
    }
}