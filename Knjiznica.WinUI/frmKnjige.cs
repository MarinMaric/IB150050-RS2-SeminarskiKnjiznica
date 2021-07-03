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
    public partial class frmKnjige : Form
    {
        APIService apiService = new APIService("Knjige");
        APIService apiKategorije = new APIService("Kategorija");
        public frmKnjige()
        {
            InitializeComponent();
        }

        private async void frmKnjige_Load(object sender, EventArgs e)
        {
            List<Knjiga> knjige = await apiService.Get<Knjiga>();
            dgvKnjige.AutoGenerateColumns = false;
            dgvKnjige.DataSource = knjige;

            var kategorije = await apiKategorije.Get<Kategorija>();
            kategorije.Insert(0, new Kategorija());
            cmbKategorija.ValueMember = "Id";
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.DataSource = kategorije;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KnjigaSearchRequest search = new KnjigaSearchRequest
            {
                Naslov = txtNaslov.Text,
                ISBN = txtISBN.Text,
                Autor=txtAutor.Text,
                KategorijaId = cmbKategorija.SelectedIndex                
            };
            
            if (int.TryParse(txtMin.Text, out int tMin))
                search.BrojStranicaMin = tMin;
            if (int.TryParse(txtMax.Text, out int tMax))
                search.BrojStranicaMax = tMax;
            if (int.TryParse(txtDostupnoMin.Text, out int tDosMin))
                search.BrojDostupnihKopijaMin = tDosMin;
            if (int.TryParse(txtDostupnoMax.Text, out int tDosMax))
                search.BrojDostupnihKopijaMax = tDosMax;
            if (int.TryParse(txtUkupnoMin.Text, out int tUkupnoMin))
                search.BrojKopijaMin = tUkupnoMin;
            if (int.TryParse(txtUkupnoMax.Text, out int tUkupnoMax))
                search.BrojKopijaMax = tUkupnoMax;
            if (search.KategorijaId == -1)
                search.KategorijaId = null;

            dgvKnjige.DataSource=await apiService.Get<Knjiga>(search);
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
            else {
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

    }
}
