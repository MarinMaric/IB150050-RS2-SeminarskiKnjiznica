using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class UpozorenjeSearchRequest
    {
        public int ClanId { get; set; }
        public string Naziv { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumOd { get; set; }
        public int KnjiznicarId { get; set; }
        public DateTime DatumDo { get; set; }
    }
}
