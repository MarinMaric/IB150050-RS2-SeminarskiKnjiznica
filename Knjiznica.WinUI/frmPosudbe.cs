using Knjiznica.Model;
using Knjiznica.Model.Requests;
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
    public partial class frmPosudbe : Form
    {
        APIService apiService = new APIService("Posudba");
        public frmPosudbe()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            PosudbaSearchRequest search = new PosudbaSearchRequest
            {
                Naslov = txtNaslov.Text,
                ClanIme = txtClan.Text,
                DatumPreuzecaOd = preuzimanjeOd.Value,
                DatumPreuzecaDo = preuzimanjeDo.Value,
                DatumPovrataDo = povratakDo.Value,
                DatumPovrataOd = povratakOd.Value,
                BrojKopije = (int)brInput.Value
            };

            dgvPosudbe.AutoGenerateColumns = false;
            dgvPosudbe.DataSource = await apiService.Get<Posudba>(search);
        }

        private void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var posudba = dgvPosudbe.SelectedRows[0].DataBoundItem;
            frmPosudbaDetalji detalji = new frmPosudbaDetalji((int)dgvPosudbe.SelectedRows[0].Cells[0].Value, posudba as Posudba);
            detalji.ShowDialog();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmKnjige knjige = new frmKnjige();
            knjige.Show();
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                preuzimanjeDo.Enabled = false;
                preuzimanjeOd.Enabled = false;
                povratakDo.Enabled = false;
                povratakOd.Enabled = false;
            }
            else
            {
                preuzimanjeDo.Enabled = true;
                preuzimanjeOd.Enabled = true;
                povratakDo.Enabled = true;
                povratakOd.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNaslov.Text = "";
            txtClan.Text = "";
            brInput.Value = 0;
            preuzimanjeDo.Enabled = false;
            preuzimanjeOd.Enabled = false;
            povratakDo.Enabled = false;
            povratakOd.Enabled = false;
            checkDate.Checked = true;
        }
    }
}
