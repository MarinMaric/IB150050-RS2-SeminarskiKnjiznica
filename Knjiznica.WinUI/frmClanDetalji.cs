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
    public partial class frmClanDetalji : Form
    {
        APIService apiService = new APIService("Clan");
        Clan _clan;

        public frmClanDetalji(Clan clan)
        {
            _clan = clan;
            InitializeComponent();
        }

        private void frmClanDetalji_Load(object sender, EventArgs e)
        {
            txtIme.Text = _clan.ImePrezime;
            txtTelefon.Text = _clan.BrojTelefona;
            txtEmail.Text = _clan.Email;

            List<Status> statuses = new List<Status>()
            {
                new Status{Value="Aktivan", Naziv="Aktivan" } ,
                new Status{Value="Deaktiviran", Naziv="Deaktiviran" } ,
                new Status{Value="Privremeni Ban", Naziv="Privremeni Ban" } ,
                new Status{Value="Dozivotni Ban", Naziv="Dozivotni Ban" } 
            };
            cmbStatus.ValueMember = "Value";
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.DataSource = statuses;

            dtmRegister.Value = _clan.DatumUclanjivanja;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            ClanInsertRequest update = new ClanInsertRequest
            {
                Status = cmbStatus.SelectedValue.ToString()
            };

            await apiService.Update<Model.Clan>(_clan.Id, update);
            this.Close();
        }

        private void linkKazne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKazne form = new frmKazne(_clan.Id);
            form.Show();
        }
    }
}
