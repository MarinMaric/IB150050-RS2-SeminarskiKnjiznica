using Knjiznica.Model;
using Knjiznica.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.WinUI.Reports
{
    public partial class RezervacijeReportView : Form
    {
        APIService _rezervacijaService = new APIService("Rezervacija");
        RezervacijaSearchRequest _search;

        public RezervacijeReportView(RezervacijaSearchRequest search)
        {
            InitializeComponent();
            _search = search;
        }

        private async void RezervacijeReportView_Load(object sender, EventArgs e)
        {
           
            List<Rezervacija> rezervacije = await _rezervacijaService.Get<Rezervacija>(_search);
            ReportDataSource rds = new ReportDataSource("posudbeReport", rezervacije);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Korisnik", _search.ImePrezime));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Naslov", _search.Naslov));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", _search.DatumRezervacijeOd.ToString("dddd, dd MMMM yyyy HH:mm:ss")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", _search.DatumRezervacijeDo.ToString("dddd, dd MMMM yyyy HH:mm:ss")));
            this.reportViewer1.RefreshReport();
        }

    }
}
