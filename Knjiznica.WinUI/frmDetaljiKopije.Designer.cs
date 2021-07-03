
namespace Knjiznica.WinUI
{
    partial class frmKopijaDetalji
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
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtBroj = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.Label();
            this.slika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtIskaznica = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.Label();
            this.btnUpozori = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnOslobodi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(34, 249);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(729, 142);
            this.txtOpis.TabIndex = 14;
            this.txtOpis.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(169, 169);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Povjest stanja";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtBroj
            // 
            this.txtBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroj.Location = new System.Drawing.Point(170, 61);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(110, 17);
            this.txtBroj.TabIndex = 11;
            this.txtBroj.Text = "Broj kopije: ";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(169, 30);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(321, 31);
            this.txtNaslov.TabIndex = 10;
            this.txtNaslov.Text = "Naslov";
            // 
            // slika
            // 
            this.slika.Location = new System.Drawing.Point(34, 30);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(129, 167);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 9;
            this.slika.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Opis štete (ukoliko je ima):";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(657, 398);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(105, 23);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi stanje";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIskaznica
            // 
            this.txtIskaznica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIskaznica.Location = new System.Drawing.Point(678, 61);
            this.txtIskaznica.Name = "txtIskaznica";
            this.txtIskaznica.Size = new System.Drawing.Size(110, 17);
            this.txtIskaznica.TabIndex = 18;
            this.txtIskaznica.Text = "Broj iskaznice: ";
            this.txtIskaznica.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtClan
            // 
            this.txtClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClan.Location = new System.Drawing.Point(467, 30);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(321, 31);
            this.txtClan.TabIndex = 17;
            this.txtClan.Text = "Posljednji član: ";
            this.txtClan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUpozori
            // 
            this.btnUpozori.Location = new System.Drawing.Point(642, 123);
            this.btnUpozori.Name = "btnUpozori";
            this.btnUpozori.Size = new System.Drawing.Size(70, 23);
            this.btnUpozori.TabIndex = 19;
            this.btnUpozori.Text = "Upozori";
            this.btnUpozori.UseVisualStyleBackColor = true;
            this.btnUpozori.Click += new System.EventHandler(this.btnUpozori_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Kazni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(170, 97);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(40, 13);
            this.txtStatus.TabIndex = 21;
            this.txtStatus.Text = "Status:";
            // 
            // btnOslobodi
            // 
            this.btnOslobodi.Location = new System.Drawing.Point(173, 123);
            this.btnOslobodi.Name = "btnOslobodi";
            this.btnOslobodi.Size = new System.Drawing.Size(75, 23);
            this.btnOslobodi.TabIndex = 22;
            this.btnOslobodi.Text = "Oslobodi";
            this.btnOslobodi.UseVisualStyleBackColor = true;
            this.btnOslobodi.Click += new System.EventHandler(this.btnOslobodi_Click);
            // 
            // frmKopijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnOslobodi);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpozori);
            this.Controls.Add(this.txtIskaznica);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.slika);
            this.Name = "frmKopijaDetalji";
            this.Text = "Kopija detalji";
            this.Load += new System.EventHandler(this.frmKopijaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txtBroj;
        private System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label txtIskaznica;
        private System.Windows.Forms.Label txtClan;
        private System.Windows.Forms.Button btnUpozori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button btnOslobodi;
    }
}