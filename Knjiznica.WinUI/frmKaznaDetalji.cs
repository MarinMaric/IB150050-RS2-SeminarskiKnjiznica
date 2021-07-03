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
    public partial class frmKaznaDetalji : Form
    {
        Kazna _kazna;
        APIService _kazneService = new APIService("Kazna");
        APIService _posudbeService = new APIService("Posudba");

        public frmKaznaDetalji(Kazna kazna)
        {
            _kazna = kazna;
            InitializeComponent();
        }

        private void frmKaznaDetalji_Load(object sender, EventArgs e)
        {
            txtPoruka.Text = _kazna.Opis;
            numInput.Value = _kazna.Iznos;
            inputDatum.Value = _kazna.Datum;

            Dictionary<int, string> status = new Dictionary<int, string>()
            {
                { 0,""},
                { 1,"Da"},
                { 2,"Ne"}
            };
            cmbPlaceno.DataSource = new BindingSource(status, null);
            cmbPlaceno.ValueMember = "Key";
            cmbPlaceno.DisplayMember = "Value";

            if (_kazna.Placeno == "Da")
                cmbPlaceno.SelectedItem = 1;
            else if (_kazna.Placeno == "Ne")
                cmbPlaceno.SelectedItem = 2;
            else cmbPlaceno.SelectedItem = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoruka.Text))
            {
                MessageBox.Show("Poruka je obavezna");
                return;
            }

            KaznaInsertRequest update = new KaznaInsertRequest { Datum = _kazna.Datum, Iznos = numInput.Value, Opis = txtPoruka.Text, PosudbaId = _kazna.PosudbaId };
            Posudba p =  _posudbeService.GetById<Posudba>(_kazna.PosudbaId);
            update.PosudbaId = p.Id;
            var opcija = (int)cmbPlaceno.SelectedValue;
            if (opcija == 1)
                update.Placeno = "Da";
            else if (opcija == 2)
                update.Placeno = "Ne";
            else update.Placeno = _kazna.Placeno;

            await _kazneService.Update<Kazna>(_kazna.Id, update);
            this.Close();
        }
    }
}
