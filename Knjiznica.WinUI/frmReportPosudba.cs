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
    public partial class frmReportPosudba : Form
    {
        public frmReportPosudba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PosudbaSearchRequest search = new PosudbaSearchRequest
            {
                ClanIme = txtIme.Text,
                Naslov = txtNaslov.Text,
                DatumPreuzecaOd = dtmOd.Value,
                DatumPreuzecaDo = dtmDo.Value
            };
            PosudbeReportView reportViewer = new PosudbeReportView(search);
            reportViewer.Show();
        }
    }
}
