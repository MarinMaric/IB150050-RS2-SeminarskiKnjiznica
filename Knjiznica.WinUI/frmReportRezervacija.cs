using Knjiznica.Model.Requests;
using Knjiznica.WinUI.Reports;
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
    public partial class frmReportRezervacija : Form
    {
        public frmReportRezervacija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervacijaSearchRequest search = new RezervacijaSearchRequest
            {
                ImePrezime = txtIme.Text,
                Naslov = txtNaslov.Text,
                DatumRezervacijeOd = dtmOd.Value,
                DatumRezervacijeDo = dtmDo.Value
            };
           
            RezervacijeReportView reportViewer = new RezervacijeReportView(search);
            reportViewer.Show();
        }
    }
}
