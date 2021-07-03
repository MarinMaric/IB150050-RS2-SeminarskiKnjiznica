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
    public partial class frmAutori : Form
    {
        APIService _service = new APIService("Autor");
        public frmAutori()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            AutorSearchRequest search=null;
            if (!string.IsNullOrEmpty(txtPretraga.Text))
                search= new AutorSearchRequest { ImePrezime = txtPretraga.Text };

            List<Autor> results = await _service.Get<Autor>(search);
            dgvAutori.AutoGenerateColumns = false;
            dgvAutori.DataSource = results;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajAutora frmDodajAutora = new frmDodajAutora();
            frmDodajAutora.Text = "Dodaj autora";
            frmDodajAutora.ShowDialog();
        }

        private void dgvAutori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var autor = dgvAutori.SelectedRows[0].DataBoundItem;
            if (_service.GetById<Autor>((int)dgvAutori.SelectedRows[0].Cells[0].Value) == null)
            {
                MessageBox.Show("Zapis je izbrisan, osvjezavamo popis");
                dgvAutori.DataSource = _service.Get<Autor>();
                return;
            }
            frmDodajAutora frmDetalji = new frmDodajAutora(autor as Autor);
            frmDetalji.Text = "Uredi autora";
            frmDetalji.ShowDialog();
        }

        private void dgvAutori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzbrisi.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvAutori.SelectedRows)
            {
                _service.Delete<Autor>(row.Cells[0].Value);
            }

            dgvAutori.DataSource = _service.Get<Autor>();
        }
    }
}