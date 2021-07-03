
namespace Knjiznica.WinUI
{
    partial class frmDodajPosudbu
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
            this.components = new System.ComponentModel.Container();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.Autor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmPovrata = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKopija = new System.Windows.Forms.ComboBox();
            this.txtIskaznica = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtIskaznica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(107, 151);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 43;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(24, 46);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(73, 13);
            this.Autor.TabIndex = 40;
            this.Autor.Text = "Broj Iskaznice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Enabled = false;
            this.txtNaslov.Location = new System.Drawing.Point(107, 18);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(184, 20);
            this.txtNaslov.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Datum povrata";
            // 
            // dtmPovrata
            // 
            this.dtmPovrata.Location = new System.Drawing.Point(107, 99);
            this.dtmPovrata.Name = "dtmPovrata";
            this.dtmPovrata.Size = new System.Drawing.Size(184, 20);
            this.dtmPovrata.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Br. Kopije";
            // 
            // cmbKopija
            // 
            this.cmbKopija.FormattingEnabled = true;
            this.cmbKopija.Location = new System.Drawing.Point(107, 72);
            this.cmbKopija.Name = "cmbKopija";
            this.cmbKopija.Size = new System.Drawing.Size(184, 21);
            this.cmbKopija.TabIndex = 61;
            // 
            // txtIskaznica
            // 
            this.txtIskaznica.Location = new System.Drawing.Point(107, 46);
            this.txtIskaznica.Name = "txtIskaznica";
            this.txtIskaznica.Size = new System.Drawing.Size(184, 20);
            this.txtIskaznica.TabIndex = 62;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodajPosudbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.Controls.Add(this.txtIskaznica);
            this.Controls.Add(this.cmbKopija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmPovrata);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaslov);
            this.Name = "frmDodajPosudbu";
            this.Text = "frmDodajPosudbu";
            this.Load += new System.EventHandler(this.frmDodajPosudbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIskaznica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmPovrata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKopija;
        private System.Windows.Forms.NumericUpDown txtIskaznica;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}