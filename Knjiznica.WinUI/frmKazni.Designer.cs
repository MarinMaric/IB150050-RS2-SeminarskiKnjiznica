
namespace Knjiznica.WinUI
{
    partial class frmKazni
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
            this.iznosInput = new System.Windows.Forms.NumericUpDown();
            this.dtmInput = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iznosInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(416, 336);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(76, 79);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(415, 238);
            this.txtPoruka.TabIndex = 8;
            this.txtPoruka.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Poruka";
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(19, 32);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(32, 13);
            this.Naslov.TabIndex = 6;
            this.Naslov.Text = "Iznos";
            // 
            // iznosInput
            // 
            this.iznosInput.Location = new System.Drawing.Point(76, 32);
            this.iznosInput.Name = "iznosInput";
            this.iznosInput.Size = new System.Drawing.Size(96, 20);
            this.iznosInput.TabIndex = 10;
            // 
            // dtmInput
            // 
            this.dtmInput.Location = new System.Drawing.Point(291, 32);
            this.dtmInput.Name = "dtmInput";
            this.dtmInput.Size = new System.Drawing.Size(200, 20);
            this.dtmInput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum";
            // 
            // frmKazni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmInput);
            this.Controls.Add(this.iznosInput);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naslov);
            this.Name = "frmKazni";
            this.Text = "frmKazni";
            this.Load += new System.EventHandler(this.frmKazni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iznosInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.NumericUpDown iznosInput;
        private System.Windows.Forms.DateTimePicker dtmInput;
        private System.Windows.Forms.Label label2;
    }
}