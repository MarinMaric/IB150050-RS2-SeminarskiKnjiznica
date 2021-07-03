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
    public partial class frmClanovi : Form
    {
        APIService apiService = new APIService("Clan");
        public frmClanovi()
        {
            InitializeComponent();
        }

        private void frmClanovi_Load(object sender, EventArgs e)
        {
            List<Status> statuses = new List<Status>()
            {
                new Status{Value="Aktivan", Naziv="Aktivan" } ,
                new Status{Value="Deaktiviran", Naziv="Deaktiviran" } ,
                new Status{Value="Privremeni Ban", Naziv="Privremeni Ban" } ,
                new Status{Value="Dozivotni Ban", Naziv="Dozivotni Ban" }
            };
            statuses.Insert(0, new Model.Status { Naziv = "", Value ="" });
            cmbStatus.ValueMember = "Value";
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.DataSource = statuses;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            ClanSearchRequest search = new ClanSearchRequest() {
                ImePrezime = txtIme.Text,
                DatumDo = dtmDo.Value,
                DatumOd = dtmOd.Value,
                UpozorenjaMax = (int)upozorenjaMax.Value,
                UpozorenjaMin = (int)upozorenjaMin.Value,
                PosudbeMax = (int)posudbeMax.Value,
                PosudbeMin = (int)posudbeMin.Value,
                Status = cmbStatus.SelectedValue.ToString()
            };

            List<Model.Clan> list = await apiService.Get<Model.Clan>(search);
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = list;
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            dtmDo.Value = DateTime.Now;
            dtmOd.Value = DateTime.Now;
            upozorenjaMax.Value = 0;
            upozorenjaMin.Value = 0;
            posudbeMax.Value = 0;
            posudbeMin.Value = 0;

            List<Model.Clan> list = await apiService.Get<Model.Clan>();
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = list;
        }

        private async void btnIzbrisi_Click(object sender, EventArgs e)
        {
            var selected = dgvClanovi.SelectedRows;

            foreach (DataGridViewRow row in selected)
            {
                apiService.Delete<Model.Clan>(row.Cells[0].Value);
            }

            List<Model.Clan> list = await apiService.Get<Model.Clan>();
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = list;
        }

        private void dgvClanovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClanDetalji detalji = new frmClanDetalji(dgvClanovi.SelectedRows[0].DataBoundItem as Model.Clan);
            detalji.ShowDialog();
        }
    }
}
