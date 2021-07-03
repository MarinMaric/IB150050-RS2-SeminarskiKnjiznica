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
    public partial class frmUpozori : Form
    {
        APIService apiService = new APIService("Upozorenje");
        Clan _clan;
        public frmUpozori(Clan clan)
        {
            _clan = clan;
            InitializeComponent();
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaslov.Text))
            {
                MessageBox.Show("Naslov je obavezan");
                return;
            }
            if (string.IsNullOrEmpty(txtPoruka.Text))
            {
                MessageBox.Show("Poruka je obavezna");
                return;
            }

            UpozorenjeInsertRequest upozorenje = new UpozorenjeInsertRequest
            {
                Naziv=txtNaslov.Text,
                Opis=txtPoruka.Text,
                ClanId=_clan.Id,
                DatumPodnosenja=DateTime.Now,
                KnjiznicarId=APIService.ID
            };
            await apiService.Insert<Upozorenje>(upozorenje);

        }
    }
}
