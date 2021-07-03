
namespace Knjiznica.WinUI
{
    partial class MainMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeNaslovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviNaslovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAutoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeClanovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjePosudbamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeRezervacijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeUplatamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pregledAutoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.clanoviToolStripMenuItem,
            this.posudbeToolStripMenuItem,
            this.uplateToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(888, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeNaslovimaToolStripMenuItem,
            this.dodajNoviNaslovToolStripMenuItem,
            this.dodajAutoraToolStripMenuItem,
            this.pregledAutoraToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // upravljanjeNaslovimaToolStripMenuItem
            // 
            this.upravljanjeNaslovimaToolStripMenuItem.Name = "upravljanjeNaslovimaToolStripMenuItem";
            this.upravljanjeNaslovimaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.upravljanjeNaslovimaToolStripMenuItem.Text = "Upravljanje naslovima";
            this.upravljanjeNaslovimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeNaslovimaToolStripMenuItem_Click);
            // 
            // dodajNoviNaslovToolStripMenuItem
            // 
            this.dodajNoviNaslovToolStripMenuItem.Name = "dodajNoviNaslovToolStripMenuItem";
            this.dodajNoviNaslovToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dodajNoviNaslovToolStripMenuItem.Text = "Dodaj novi naslov";
            this.dodajNoviNaslovToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviNaslovToolStripMenuItem_Click);
            // 
            // dodajAutoraToolStripMenuItem
            // 
            this.dodajAutoraToolStripMenuItem.Name = "dodajAutoraToolStripMenuItem";
            this.dodajAutoraToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dodajAutoraToolStripMenuItem.Text = "Dodaj autora";
            this.dodajAutoraToolStripMenuItem.Click += new System.EventHandler(this.dodajAutoraToolStripMenuItem_Click);
            // 
            // clanoviToolStripMenuItem
            // 
            this.clanoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeClanovimaToolStripMenuItem});
            this.clanoviToolStripMenuItem.Name = "clanoviToolStripMenuItem";
            this.clanoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clanoviToolStripMenuItem.Text = "Clanovi";
            // 
            // upravljanjeClanovimaToolStripMenuItem
            // 
            this.upravljanjeClanovimaToolStripMenuItem.Name = "upravljanjeClanovimaToolStripMenuItem";
            this.upravljanjeClanovimaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.upravljanjeClanovimaToolStripMenuItem.Text = "Upravljanje clanovima";
            this.upravljanjeClanovimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeClanovimaToolStripMenuItem_Click);
            // 
            // posudbeToolStripMenuItem
            // 
            this.posudbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjePosudbamaToolStripMenuItem,
            this.upravljanjeRezervacijamaToolStripMenuItem});
            this.posudbeToolStripMenuItem.Name = "posudbeToolStripMenuItem";
            this.posudbeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.posudbeToolStripMenuItem.Text = "Posudbe";
            // 
            // upravljanjePosudbamaToolStripMenuItem
            // 
            this.upravljanjePosudbamaToolStripMenuItem.Name = "upravljanjePosudbamaToolStripMenuItem";
            this.upravljanjePosudbamaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.upravljanjePosudbamaToolStripMenuItem.Text = "Upravljanje posudbama";
            this.upravljanjePosudbamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjePosudbamaToolStripMenuItem_Click);
            // 
            // upravljanjeRezervacijamaToolStripMenuItem
            // 
            this.upravljanjeRezervacijamaToolStripMenuItem.Name = "upravljanjeRezervacijamaToolStripMenuItem";
            this.upravljanjeRezervacijamaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.upravljanjeRezervacijamaToolStripMenuItem.Text = "Upravljanje rezervacijama";
            this.upravljanjeRezervacijamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeRezervacijamaToolStripMenuItem_Click);
            // 
            // uplateToolStripMenuItem
            // 
            this.uplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeUplatamaToolStripMenuItem});
            this.uplateToolStripMenuItem.Name = "uplateToolStripMenuItem";
            this.uplateToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.uplateToolStripMenuItem.Text = "Uplate";
            // 
            // upravljanjeUplatamaToolStripMenuItem
            // 
            this.upravljanjeUplatamaToolStripMenuItem.Name = "upravljanjeUplatamaToolStripMenuItem";
            this.upravljanjeUplatamaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.upravljanjeUplatamaToolStripMenuItem.Text = "Upravljanje uplatama";
            this.upravljanjeUplatamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeUplatamaToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posudbeToolStripMenuItem1,
            this.posudbeToolStripMenuItem2});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // posudbeToolStripMenuItem1
            // 
            this.posudbeToolStripMenuItem1.Name = "posudbeToolStripMenuItem1";
            this.posudbeToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.posudbeToolStripMenuItem1.Text = "Rezervacije";
            this.posudbeToolStripMenuItem1.Click += new System.EventHandler(this.posudbeToolStripMenuItem1_Click);
            // 
            // posudbeToolStripMenuItem2
            // 
            this.posudbeToolStripMenuItem2.Name = "posudbeToolStripMenuItem2";
            this.posudbeToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.posudbeToolStripMenuItem2.Text = "Posudbe";
            this.posudbeToolStripMenuItem2.Click += new System.EventHandler(this.posudbeToolStripMenuItem2_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 520);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(888, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pregledAutoraToolStripMenuItem
            // 
            this.pregledAutoraToolStripMenuItem.Name = "pregledAutoraToolStripMenuItem";
            this.pregledAutoraToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pregledAutoraToolStripMenuItem.Text = "Pregled autora";
            this.pregledAutoraToolStripMenuItem.Click += new System.EventHandler(this.pregledAutoraToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 542);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeNaslovimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviNaslovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeClanovimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjePosudbamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeRezervacijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem posudbeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajAutoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeUplatamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledAutoraToolStripMenuItem;
    }
}



