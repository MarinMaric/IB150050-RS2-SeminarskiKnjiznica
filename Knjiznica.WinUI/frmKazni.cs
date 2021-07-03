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
    public partial class frmKazni : Form
    {
        APIService apiService = new APIService("Kazna");
        int _rezervacijaId;
        public frmKazni(int recenzijaId)
        {
            _rezervacijaId = recenzijaId;
            InitializeComponent();
        }

        private void frmKazni_Load(object sender, EventArgs e)
        {
            


        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            KaznaInsertRequest insert = new KaznaInsertRequest
            {
                Datum = dtmInput.Value,
                Iznos = iznosInput.Value,
                Opis = txtPoruka.Text,
                KnjiznicarId = APIService.ID,
                RezervacijaId = _rezervacijaId
            };

            await apiService.Insert<Model.Kazna>(insert);
        }
    }
}
