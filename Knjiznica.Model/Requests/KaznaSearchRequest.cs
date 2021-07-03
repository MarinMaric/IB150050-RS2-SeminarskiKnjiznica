using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class KaznaSearchRequest
    {
        public int ClanId { get; set; }
        public string ClanIme { get; set; }
        public int KopijaId { get; set; }
        public int Iznos { get; set; }
        public string Placeno { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int PodnioId { get; set; }

    }
}
