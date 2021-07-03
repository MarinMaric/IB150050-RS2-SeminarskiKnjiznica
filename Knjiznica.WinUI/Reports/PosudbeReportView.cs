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
    public partial class PosudbeReportView : Form
    {
        APIService _posudbaService = new APIService("Posudba");
        PosudbaSearchRequest _search;

        private async void PosudbeReportView_Load(object sender, EventArgs e)
        {
            
            List<Posudba> posudbe = await _posudbaService.Get<Posudba>(_search);
            ReportDataSource rds = new ReportDataSource("posudbeReport", posudbe);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Korisnik", _search.ClanIme));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Naslov", _search.Naslov));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", _search.DatumPreuzecaOd.ToString("dddd, dd MMMM yyyy HH:mm:ss")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", _search.DatumPreuzecaDo.ToString("dddd, dd MMMM yyyy HH:mm:ss")));
            this.reportViewer1.RefreshReport();
        }

        public PosudbeReportView(PosudbaSearchRequest search)
        {
            InitializeComponent();
            _search = search;
        }
    }
}
