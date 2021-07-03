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
    public partial class frmKnjigePretraga : Form
    {
        APIService _service;
        public frmKnjigePretraga()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KnjigaSearchRequest search = new KnjigaSearchRequest();
            search.Naslov = txtPretraga.Text;

            List<Knjiga> results = await _service.Get<Knjiga>(search);
            dgvKnjige.Rows.Add(results);
        }
    }
}
