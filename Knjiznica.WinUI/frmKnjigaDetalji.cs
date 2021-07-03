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
    public partial class frmKnjigaDetalji : Form
    {
        APIService _serviceKnjige = new APIService("Knjige");
        APIService _serviceKopije = new APIService("Kopije");
        Model.Knjiga _knjiga;

        public frmKnjigaDetalji(Model.Knjiga knjiga)
        {
            _knjiga = knjiga;
            InitializeComponent();
        }

        private void frmKnjigaDetalji_Load(object sender, EventArgs e)
        {
            txtAutor.Text = _knjiga.Autor;
            txtNaslov.Text = _knjiga.Naslov;
            txtOpis.Text = _knjiga.Opis;

            using(MemoryStream ms = new MemoryStream(_knjiga.Slika))
            {
                slika.Image = Image.FromStream(ms);
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            DodajKnjigu dodajKnjigu = new DodajKnjigu(_knjiga);
            dodajKnjigu.ShowDialog();
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            _serviceKnjige.Delete<Knjiga>(_knjiga.Id);
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            dgvKopije.AutoGenerateColumns = false;

            KopijaSearchRequest search = new KopijaSearchRequest {
                KnjigaId = _knjiga.Id,
                Zauzeta = -1
            };

            if (!string.IsNullOrEmpty(txtKopija.Text))
            {
                search.ID = int.Parse(txtKopija.Text);               
            }

            var list = await _serviceKopije.Get<Model.Kopija>(search);
            dgvKopije.DataSource = list;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            KopijaInsertRequest insert = new KopijaInsertRequest
            {
                KnjigaId = _knjiga.Id,
            };
            await _serviceKopije.Insert<Kopija>(insert);
        }

        private void btnIzbrisiKopiju_Click(object sender, EventArgs e)
        {
            var rows = dgvKopije.SelectedRows;
            foreach(DataGridViewRow r in rows)
            {
                _serviceKopije.Delete<Model.Kopija>(r.Cells[0].Value);
            }
        }

        private void dgvKopije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmKopijaDetalji frmKopijaDetalji = new frmKopijaDetalji(dgvKopije.SelectedRows[0].DataBoundItem as Model.Kopija);
            frmKopijaDetalji.ShowDialog();
        }
    }
}
