using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.WinUI
{
    public partial class frmKopijaDetalji : Form
    {
        APIService apiService = new APIService("Stanje");
        APIService _kopijeService = new APIService("Kopije");
        Kopija _kopija;
       
        public frmKopijaDetalji(Kopija kopija)
        {
            _kopija = kopija;
            InitializeComponent();
        }

        private void frmKopijaDetalji_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = _kopija.Knjiga.Naslov;
            txtBroj.Text = _kopija.BrojKopije.ToString();

            if (_kopija.Zauzeta == 0)
                txtStatus.Text = "Status: Slobodna";
            else txtStatus.Text = "Status: Posuđena";

            using(MemoryStream ms = new MemoryStream(_kopija.Knjiga.Slika))
            {
                slika.Image = Image.FromStream(ms);
            }

            if (_kopija.PosljednjiVlasnik != null)
            {
                txtClan.Text += _kopija.PosljednjiVlasnik.ImePrezime;
                txtIskaznica.Text += _kopija.PosljednjiVlasnik.Id.ToString();
            }
            else {
                txtClan.Text += "-/-";
                txtIskaznica.Text += "-/-";

                btnUpozori.Enabled = false;
                button1.Enabled = false;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            StanjeInsertRequest stanje = new StanjeInsertRequest()
            {
                Opis = txtOpis.Text,
                VlasnikId = 2,
                DatumBiljezenja = DateTime.Now,
                KopijaId = _kopija.Id
            };

            await apiService.Insert<Stanje>(stanje);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPovjestStanja povjestStanja = new frmPovjestStanja(_kopija);
            povjestStanja.ShowDialog();
        }

        private void btnUpozori_Click(object sender, EventArgs e)
        {
            frmUpozori upozori = new frmUpozori(_kopija.PosljednjiVlasnik);
            upozori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            frmKazna kazna = new frmKazna(_kopija);
            kazna.ShowDialog();
        }

        private async void btnOslobodi_Click(object sender, EventArgs e)
        {
            if (_kopija.Zauzeta == 1)
            {
                KopijaInsertRequest update = new KopijaInsertRequest
                {
                    KnjigaId = _kopija.Id,
                    Zauzeta = 0
                };

                await _kopijeService.Update<Kopija>(_kopija.Id, update);
            }
            this.Refresh();
            return;
        }
    }
}
