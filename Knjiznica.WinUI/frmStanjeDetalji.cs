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
    public partial class frmStanjeDetalji : Form
    {
        APIService apiService = new APIService("Stanje");
        Stanje _stanje;
        public frmStanjeDetalji(Stanje stanje)
        {
            _stanje = stanje;
            InitializeComponent();
        }

        private void frmStanjeDetalji_Load(object sender, EventArgs e)
        {
            txtClan.Text += _stanje.Vlasnik;
            txtDatum.Text += _stanje.DatumBiljezenja.ToString();
            txtOpis.Text = _stanje.Opis;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            StanjeInsertRequest insert = new StanjeInsertRequest {
                Opis = txtOpis.Text
            };
            await apiService.Update<Model.Stanje>(_stanje.Id, insert);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            apiService.Delete<Model.Stanje>(_stanje.Id);
        }
    }
}
