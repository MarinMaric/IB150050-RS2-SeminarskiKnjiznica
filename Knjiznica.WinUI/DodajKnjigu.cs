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
    public partial class DodajKnjigu : Form
    {
        APIService apiService = new APIService("Knjige");
        APIService apiAutori = new APIService("Autor");
        APIService apiKategorije = new APIService("Kategorija");
        Model.Knjiga _knjiga;

        public DodajKnjigu(Model.Knjiga knjiga=null)
        {
            if (knjiga != null)
                _knjiga = knjiga;

            InitializeComponent();
        }

        private async void DodajKnjigu_Load(object sender, EventArgs e)
        {
            var kategorije = await apiKategorije.Get<Kategorija>();
            kategorije.Insert(0, new Kategorija());
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "Id";
            cmbKategorija.DataSource = kategorije;

            if (_knjiga != null)
            {

                cmbKategorija.SelectedIndex = _knjiga.KategorijaId;

                txtNaslov.Text = _knjiga.Naslov;
                txtAutor.Text = _knjiga.Autor;
                txtISBN.Text = _knjiga.ISBN;
                inputIzdanje.Value = _knjiga.Izdanje;
                txtOpis.Text = _knjiga.Opis;
                inputBrStranica.Value = _knjiga.BrojStranica;
                inputDatum.Value = _knjiga.DatumIzdavanja;

                using(MemoryStream ms = new MemoryStream(_knjiga.Slika)) {
                    slika.Image = Image.FromStream(ms);
                }
            }
            else
            {
                btnIzbrisi.Hide();
            }
        }

        //Dodaj novu knjigu
        KnjigaInsertRequest insert = new KnjigaInsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!CheckValidation())
                return;

            AutorSearchRequest search = new AutorSearchRequest { ImePrezime = txtAutor.Text };
            var list = await apiAutori.Get<Model.Autor>(search);
            if (list.Count == 0)
            {
                MessageBox.Show("Autor ne postoji", "Greška");
                return;
            }
            Autor a = list.First();

            insert.Naslov = txtNaslov.Text;
            insert.AutorId = a.Id;
            insert.ISBN = txtISBN.Text;
            insert.Izdanje = (int)inputIzdanje.Value;
            insert.BrojStranica = (int)inputBrStranica.Value;
            insert.KategorijaId = (int)cmbKategorija.SelectedValue;
            insert.DatumIzdavanja = inputDatum.Value;
            insert.Opis = txtOpis.Text;

            if (_knjiga != null)
            {
                if (insert.Slika == null)
                {
                    using(MemoryStream ms = new MemoryStream(_knjiga.Slika))
                    {
                        var test = Image.FromStream(ms);
                    }
                    insert.Slika = _knjiga.Slika;
                }
                
                await apiService.Update<Knjiga>(_knjiga.Id, insert);
            }
            else
                await apiService.Insert<Knjiga>(insert);


            this.Close();
        }

        //Ucitaj sliku
        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var dialogResult = openFileDialog.ShowDialog();
            
            if(dialogResult == DialogResult.OK)
            {
                var file = File.ReadAllBytes(openFileDialog.FileName);
                Image image = Image.FromFile(openFileDialog.FileName);
                if (image.Width > 250 || image.Height>400)
                {
                    MessageBox.Show("Dimenzije slike mogu biti maksimalno 250x400px");
                }
                else
                {
                    insert.Slika = file;
                    slika.Image = image;
                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            apiService.Delete<Knjiga>(_knjiga.Id);
            this.Close();
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaslov.Text))
            {
                errorProvider.SetError(txtNaslov, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }
        private void txtAutor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                errorProvider.SetError(txtAutor, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtAutor, null);
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                errorProvider.SetError(txtISBN, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtISBN, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }

        private void slika_Validating(object sender, CancelEventArgs e)
        {
            if (slika.Image == null)
            {
                errorProvider.SetError(slika, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }

        private void inputBrStranica_Validating(object sender, CancelEventArgs e)
        {
            if (inputBrStranica.Value ==0)
            {
                errorProvider.SetError(inputBrStranica, "Knjiga mora imati definiran broj stranica");
            }
            else
            {
                errorProvider.SetError(inputBrStranica, null);
            }
        }

        bool CheckValidation() {
            var test = errorProvider.GetError(txtNaslov);
            if (!string.IsNullOrEmpty(errorProvider.GetError(txtNaslov)))
                return false;
            if (!string.IsNullOrEmpty(errorProvider.GetError(txtAutor)))
                return false;
            if (!string.IsNullOrEmpty(errorProvider.GetError(txtOpis)))
                return false;
            if (!string.IsNullOrEmpty(errorProvider.GetError(txtISBN)))
                return false;
            if (!string.IsNullOrEmpty(errorProvider.GetError(inputBrStranica)))
                return false;
            if (!string.IsNullOrEmpty(errorProvider.GetError(slika)))
                return false;

            return true;
        }
    }
}
