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
    public partial class frmDodajPosudbu : Form
    {
        APIService _clanService = new APIService("Clan");
        APIService _kopijaService = new APIService("Kopije");
        APIService _posudbaService = new APIService("Posudba");
        Knjiga _knjiga;

        public frmDodajPosudbu(Knjiga knjiga)
        {
            _knjiga = knjiga;
            InitializeComponent();
        }

        private async void frmDodajPosudbu_Load(object sender, EventArgs e)
        {
            KopijaSearchRequest search = new KopijaSearchRequest
            {
                KnjigaId = _knjiga.Id,
                Zauzeta = 0
            };
            var list = await _kopijaService.Get<Kopija>(search);

            Kopija kDefault = new Kopija();
            list.Insert(0, kDefault);
            cmbKopija.ValueMember = "Id";
            cmbKopija.DisplayMember = "BrojKopije";
            cmbKopija.DataSource = list;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            ClanSearchRequest search = new ClanSearchRequest
            {
                BrojIskaznice = (int)txtIskaznica.Value
            };

            var list = await _clanService.Get<Clan>(search);
            Clan clan;
            if (list.Count > 0)
            {
                clan=list.First();
            }
            else
            {
                MessageBox.Show("Invalid broj iskaznice");
                return;
            }

            PosudbaInsertRequest insert = new PosudbaInsertRequest
            {
                ClanId=clan.Id,
                DatumPovrata=dtmPovrata.Value,
                DatumPreuzeca=DateTime.Now,
                KnjigaId=_knjiga.Id
            };

            if (cmbKopija.SelectedIndex >0)
            {
                insert.KopijaId  = (int)cmbKopija.SelectedValue;
            }
            else
            {
                MessageBox.Show("Invalid broj kopije");
                return;
            }

            await _posudbaService.Insert<Posudba>(insert);

            KopijaInsertRequest update = new KopijaInsertRequest { 
                KnjigaId=insert.KnjigaId,
                Zauzeta = 1,
                ClanId=clan.Id
            };
            await _kopijaService.Update<Kopija>(insert.KopijaId, update);
        }
    }
}
