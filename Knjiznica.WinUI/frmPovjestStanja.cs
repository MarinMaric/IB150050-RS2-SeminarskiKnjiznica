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
    public partial class frmPovjestStanja : Form
    {
        APIService apiService = new APIService("Stanje");
        Kopija _kopija;

        public frmPovjestStanja(Kopija kopija)
        {
            _kopija = kopija;
            InitializeComponent();
        }

        private async void frmPovjestStanja_Load(object sender, EventArgs e)
        {
            dgvStanja.AutoGenerateColumns = false;
            StanjeSearchRequest search = new StanjeSearchRequest { KopijaId=_kopija.Id };
            dgvStanja.DataSource= await apiService.Get<Model.Stanje>(search);
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            StanjeSearchRequest search = new StanjeSearchRequest
            {
                Vlasnik = txtIme.Text,
                DatumBilježenja = dtmBiljezenja.Value,
                KopijaId = _kopija.Id
            };
            dgvStanja.AutoGenerateColumns = false;
            dgvStanja.DataSource = await apiService.Get<Model.Stanje>(search);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvStanja.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                apiService.Delete<Model.Stanje>(row.Cells[0].Value);
            }
        }

        private void dgvStanja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStanjeDetalji stanjeDetalji = new frmStanjeDetalji(dgvStanja.SelectedRows[0].DataBoundItem as Model.Stanje);
            stanjeDetalji.ShowDialog();
        }
    }
}
