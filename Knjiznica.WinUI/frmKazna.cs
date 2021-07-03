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
    public partial class frmKazna : Form
    {
        APIService apiService = new APIService("Kazna");
        APIService _posudbeService = new APIService("Posudba");
        Kopija _kopija;
        public frmKazna(Kopija  kopija)
        {
            _kopija = kopija;
            InitializeComponent();
        }

        private void frmKazna_Load(object sender, EventArgs e)
        {

        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoruka.Text))
            {
                MessageBox.Show("Poruka je obavezna");
                return;
            }

            KaznaInsertRequest insert = new KaznaInsertRequest {
                Datum = DateTime.Now,
                Iznos = numInput.Value,
                Opis = txtPoruka.Text,
                KnjiznicarId = APIService.ID
            };

            PosudbaSearchRequest search = new PosudbaSearchRequest
            {
                BrojKopije = _kopija.BrojKopije,
                ClanId = _kopija.PosljednjiVlasnik.Id,
                ClanIme = _kopija.PosljednjiVlasnik.ImePrezime,
                Naslov = _kopija.Knjiga.Naslov
            };

            var list = await _posudbeService.Get<Model.Posudba>(search);

            insert.PosudbaId= list[list.Count - 1].Id;

            await apiService.Insert<Model.Kazna>(insert);
            this.Close();
        }
    }
}
