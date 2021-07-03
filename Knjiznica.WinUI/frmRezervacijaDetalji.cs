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
    public partial class frmRezervacijaDetalji : Form
    {
        Rezervacija _rezervacija;
        int rezId;
        APIService _service = new APIService("Rezervacija");
        public frmRezervacijaDetalji(int id, Rezervacija rezervacija)
        {
            _rezervacija = rezervacija;
            rezId = id;
            InitializeComponent();
        }

        private void frmRezervacijaDetalji_Load(object sender, EventArgs e)
        {
            txtIme.Text = _rezervacija.ImePrezime;
            txtNaslov.Text = _rezervacija.Naslov;
            dtmIsteka.Text = _rezervacija.DatumIsteka.ToString();
            dtmRezervacije.Text = _rezervacija.DatumRezervacije.ToString();

            List<string> listaStatusa = new List<string>
            {
                "Aktivna", "Prekinuta", "Dovršena"
            };
            listaStatusa.Insert(0, "");
            cmbStatus.ValueMember = "Id";
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.DataSource = listaStatusa;

            int status;
            switch (_rezervacija.Status)
            {
                case "Aktivna":status = 1;break;
                case "Prekinuta":status = 2;break;
                case "Dovršena":status = 3;break;
                default:status = 0;
                    break;
            }

            cmbStatus.SelectedIndex = status;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex > 0)
            {
                RezervacijaInsertRequest update = new RezervacijaInsertRequest
                {
                    StatusId = cmbStatus.SelectedIndex
                };
                
                await _service.Update<Rezervacija>(rezId, update);
            }
                
        }
    }
}
