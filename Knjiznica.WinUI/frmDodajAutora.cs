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
    public partial class frmDodajAutora : Form
    {
        APIService _service=new APIService("Autor");
        Autor _autor;
        AutorInsertRequest insert=new AutorInsertRequest();
        public frmDodajAutora(Autor autor=null)
        {
            InitializeComponent();
            if (autor != null)
                _autor = autor;
        }
        private void frmDodajAutora_Load(object sender, EventArgs e)
        {
            if (_autor != null)
            {
                string[] imeDijelovi = _autor.ImePrezime.Split(' ');

                if (imeDijelovi.Length > 2)
                {
                    txtIme.Text = imeDijelovi[0];
                    txtPrezime.Text = imeDijelovi[1];

                    for (int i = 2; i < imeDijelovi.Length; i++)
                    {
                        txtPrezime.Text += (" " + imeDijelovi[i]);
                    }
                }
                else
                {
                    txtIme.Text = imeDijelovi[0];
                    txtPrezime.Text = imeDijelovi[1];
                }
            }
            else
            {
                btnIzbrisi.Hide();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            if (!CheckValidation())
            {
                return;
            }


            insert.Ime = txtIme.Text;
            insert.Prezime = txtPrezime.Text;

            if (_autor != null)
            {
                await _service.Update<Autor>(_autor.Id, insert);
            }
            else
            {
                await _service.Insert<Autor>(insert);
            }

            this.Close();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, "Polje je obavezno");
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                _service.Delete<Autor>(_autor.Id);
                this.Close();
            }
        }

        bool CheckValidation()
        {
            if (string.IsNullOrEmpty(errorProvider.GetError(txtIme)))
                return false;
            if (string.IsNullOrEmpty(errorProvider.GetError(txtPrezime)))
                return false;
            return true; 
        }
    }
}