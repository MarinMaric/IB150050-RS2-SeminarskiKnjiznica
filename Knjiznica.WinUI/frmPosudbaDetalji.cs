using Knjiznica.Model;
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
    public partial class frmPosudbaDetalji : Form
    {
        Posudba _posudba;
        int _posId;
        APIService _service = new APIService("Posudba");
        public frmPosudbaDetalji(int id, Posudba posudba)
        {
            _posudba = posudba;
            _posId = id;
            InitializeComponent();
        }

        private void frmPosudbaDetalji_Load(object sender, EventArgs e)
        {
            txtIme.Text = _posudba.ClanIme;
            txtNaslov.Text = _posudba.Naslov;
            dtmPovratak.Text = _posudba.DatumPovrata.ToString();
            dtmPreuzeto.Text = _posudba.DatumPreuzeca.ToString();
            txtKopija.Text = _posudba.BrojKopije.ToString();
        }
    }
}
