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
    public partial class frmRezervacije : Form
    {
        APIService apiService = new APIService("Rezervacija");

        public frmRezervacije()
        {
            InitializeComponent();
        }
        private async void frmKnjige_Load(object sender, EventArgs e)
        {
            List<string> listaStatusa = new List<string>
            {
                "Aktivna", "Prekinuta", "Dovršena"
            };
            var kategorije = listaStatusa;
            kategorije.Insert(0, "");
            cmbStatus.ValueMember = "Id";
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.DataSource = listaStatusa;
        }
         
        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            RezervacijaSearchRequest search = new RezervacijaSearchRequest
            {
                Naslov = txtNaslov.Text,
                ImePrezime=txtClan.Text,
                DatumRezervacijeOd=checkDate.Checked?new DateTime():dtmOd.Value,
                DatumRezervacijeDo= checkDate.Checked ? new DateTime() : dtmDo.Value,
                StatusId = cmbStatus.SelectedIndex
            };
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = await apiService.Get<Rezervacija>(search);
        }

        private void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rez = dgvRezervacije.SelectedRows[0].DataBoundItem;
            frmRezervacijaDetalji detalji = new frmRezervacijaDetalji((int)dgvRezervacije.SelectedRows[0].Cells[0].Value, rez as Rezervacija);
            detalji.ShowDialog();
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
            txtNaslov.Text = "";
            txtClan.Text = "";
            cmbStatus.SelectedIndex = 0;
            dtmDo.Enabled = false;
            dtmDo.Enabled = false;
            checkDate.Checked = true;
        }
    }
}
