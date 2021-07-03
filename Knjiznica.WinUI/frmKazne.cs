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
    public partial class frmKazne : Form
    {
        int _clanId;
        APIService apiService = new APIService("Kazna");
        public frmKazne(int clanId)
        {
            _clanId = clanId;
            InitializeComponent();
        }

        private async void frmKazne_Load(object sender, EventArgs e)
        {
            KaznaSearchRequest searchRequest = new KaznaSearchRequest { ClanId = _clanId };
            List<Kazna> kazne = await apiService.Get<Kazna>(searchRequest);
            dgvKazne.AutoGenerateColumns = false;
            dgvKazne.DataSource = kazne;

            Dictionary<int, string> status = new Dictionary<int, string>()
            {
                { 0,""},
                { 1,"Da"},
                { 2,"Ne"}
            };
            cmbPlaceno.DataSource = new BindingSource(status, null);
            cmbPlaceno.ValueMember = "Key";
            cmbPlaceno.DisplayMember = "Value";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KaznaSearchRequest search = new KaznaSearchRequest
            {
                ClanId = _clanId,
                Iznos = (int)numIznos.Value,
            };
            var placenoGet = (int)cmbPlaceno.SelectedValue;
            if (placenoGet == 1)
                search.Placeno = "Da";
            else if (placenoGet == 2)
                search.Placeno = "Ne";
            else search.Placeno = "";

            dgvKazne.DataSource = await apiService.Get<Kazna>(search);
        }

        private void dgvKazne_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var k = dgvKazne.SelectedRows[0].DataBoundItem as Kazna;
            frmKaznaDetalji form = new frmKaznaDetalji(k);
            form.Show();
        }
    }
}
