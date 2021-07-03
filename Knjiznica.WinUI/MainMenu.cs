using Knjiznica.WinUI.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.WinUI
{
    public partial class MainMenu : Form
    {
        private int childFormNumber = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void upravljanjeNaslovimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                frmKnjige frmKnjige = new frmKnjige();
                frmKnjige.MdiParent = this;
                frmKnjige.WindowState = FormWindowState.Maximized;
                frmKnjige.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Aha");
            }
        }

        private void dodajNoviNaslovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKnjigu dodajKnjigu = new DodajKnjigu();
            dodajKnjigu.MdiParent=this;
            dodajKnjigu.WindowState = FormWindowState.Maximized;
            dodajKnjigu.Show();
        }

        private void upravljanjeClanovimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanovi forma = new frmClanovi();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutori forma = new frmAutori();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void upravljanjeRezervacijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacije forma = new frmRezervacije();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
        private void upravljanjePosudbamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosudbe forma = new frmPosudbe();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void posudbeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportRezervacija forma = new frmReportRezervacija();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void posudbeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReportPosudba forma = new frmReportPosudba();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void dodajAutoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajAutora forma = new frmDodajAutora();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void upravljanjeUplatamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUplate forma = new frmUplate();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pregledAutoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutori forma = new frmAutori();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
    }
}
