
namespace Knjiznica.WinUI
{
    partial class frmPosudbaDetalji
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
            this.dtmPovratak = new System.Windows.Forms.Label();
            this.dtmPreuzeto = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Posudio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKopija = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtmPovratak
            // 
            this.dtmPovratak.AutoSize = true;
            this.dtmPovratak.Location = new System.Drawing.Point(101, 100);
            this.dtmPovratak.Name = "dtmPovratak";
            this.dtmPovratak.Size = new System.Drawing.Size(43, 13);
            this.dtmPovratak.TabIndex = 78;
            this.dtmPovratak.Text = "Naslov:";
            // 
            // dtmPreuzeto
            // 
            this.dtmPreuzeto.AutoSize = true;
            this.dtmPreuzeto.Location = new System.Drawing.Point(101, 73);
            this.dtmPreuzeto.Name = "dtmPreuzeto";
            this.dtmPreuzeto.Size = new System.Drawing.Size(43, 13);
            this.dtmPreuzeto.TabIndex = 77;
            this.dtmPreuzeto.Text = "Naslov:";
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.Location = new System.Drawing.Point(101, 47);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(43, 13);
            this.txtIme.TabIndex = 76;
            this.txtIme.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Location = new System.Drawing.Point(101, 21);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(43, 13);
            this.txtNaslov.TabIndex = 75;
            this.txtNaslov.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Vraćeno:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(104, 183);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 73;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(25, 73);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 13);
            this.Email.TabIndex = 72;
            this.Email.Text = "Preuzeto:";
            // 
            // Posudio
            // 
            this.Posudio.AutoSize = true;
            this.Posudio.Location = new System.Drawing.Point(25, 47);
            this.Posudio.Name = "Posudio";
            this.Posudio.Size = new System.Drawing.Size(61, 13);
            this.Posudio.TabIndex = 71;
            this.Posudio.Text = "Rezervirao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Naslov:";
            // 
            // txtKopija
            // 
            this.txtKopija.AutoSize = true;
            this.txtKopija.Location = new System.Drawing.Point(101, 125);
            this.txtKopija.Name = "txtKopija";
            this.txtKopija.Size = new System.Drawing.Size(43, 13);
            this.txtKopija.TabIndex = 79;
            this.txtKopija.Text = "Naslov:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Br. kopije";
            // 
            // frmPosudbaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 219);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKopija);
            this.Controls.Add(this.dtmPovratak);
            this.Controls.Add(this.dtmPreuzeto);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Posudio);
            this.Controls.Add(this.label1);
            this.Name = "frmPosudbaDetalji";
            this.Text = "frmPosudbaDetalji";
            this.Load += new System.EventHandler(this.frmPosudbaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dtmPovratak;
        private System.Windows.Forms.Label dtmPreuzeto;
        private System.Windows.Forms.Label txtIme;
        private System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Posudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtKopija;
        private System.Windows.Forms.Label label5;
    }
}