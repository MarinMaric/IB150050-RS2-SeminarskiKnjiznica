
namespace Knjiznica.WinUI
{
    partial class frmUpozori
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(74, 31);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(415, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(17, 34);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(40, 13);
            this.Naslov.TabIndex = 1;
            this.Naslov.Text = "Naslov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poruka";
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(74, 81);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(415, 238);
            this.txtPoruka.TabIndex = 3;
            this.txtPoruka.Text = "";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(414, 338);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmUpozori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 386);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.txtNaslov);
            this.Name = "frmUpozori";
            this.Text = "frmUpozori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Button btnSpremi;
    }
}