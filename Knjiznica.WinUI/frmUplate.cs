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
    public partial class frmUplate : Form
    {
        APIService apiService = new APIService("Uplata");
        APIService apiKategorije = new APIService("Kategorija");
        public frmUplate()
        {
            InitializeComponent();
        }

        private async void frmUplate_Load(object sender, EventArgs e)
        {
            List<UplataClanarine> uplate = await apiService.Get<UplataClanarine>();
            dgvKnjige.AutoGenerateColumns = false;
            dgvKnjige.DataSource = uplate;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKnjigu dodajKnjigu = new DodajKnjigu();
            dodajKnjigu.ShowDialog();
        }

        private async void dgvKnjige_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (apiService.GetById<Knjiga>((int)dgvKnjige.SelectedRows[0].Cells[0].Value) == null)
            {
                MessageBox.Show("Zapis je izbrisan, osvježavamo listu.");
                await apiService.Get<Knjiga>();
            }
            else
            {
                var knjiga = apiService.GetById<Knjiga>((int)dgvKnjige.SelectedRows[0].Cells[0].Value);
                frmKnjigaDetalji detalji = new frmKnjigaDetalji(knjiga);
                detalji.ShowDialog();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvKnjige.SelectedRows)
            {
                var id = row.Cells[0].Value;
                apiService.Delete<Knjiga>((int)id);
            }
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            var knjiga = dgvKnjige.SelectedRows[0].DataBoundItem;
            frmDodajPosudbu dodajPosudbu = new frmDodajPosudbu(knjiga as Knjiga);
            dodajPosudbu.ShowDialog();
            this.Close();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            UplataSearchRequest searchRequest = new UplataSearchRequest
            {
                ClanIme = txtIme.Text,
                DatumUplacivanjaOd = checkDate.Checked?DateTime.MinValue: dtmOd.Value,
                DatumUplacivanjaDo = checkDate.Checked ? DateTime.MinValue:dtmDo.Value
            };

            List<UplataClanarine> uplate = await apiService.Get<UplataClanarine>(searchRequest);
            dgvKnjige.AutoGenerateColumns = false;
            dgvKnjige.DataSource = uplate;
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtmOd.Enabled = false;
                dtmDo.Enabled = false;
            }
            else
            {
                dtmOd.Enabled = true;
                dtmDo.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtOpis.Text = "";
            iznosMin.Value = 0;
            iznosMax.Value = 0;
            dtmOd.Value = DateTime.Now;
            dtmDo.Value = DateTime.Now;
            dtmOd.Enabled = false;
            dtmDo.Enabled = false;
            checkDate.Checked = true;
        }
    }
}
