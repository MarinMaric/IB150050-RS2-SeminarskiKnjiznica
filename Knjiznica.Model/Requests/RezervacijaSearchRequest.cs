using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public string Naslov { get; set; }
        public int ClanId { get; set; }
        public DateTime DatumRezervacijeOd { get; set; }
        public DateTime DatumRezervacijeDo { get; set; }
        public int StatusId { get; set; }
        public string ImePrezime { get; set; }
    }
}
