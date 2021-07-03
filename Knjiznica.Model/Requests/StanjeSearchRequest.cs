using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class StanjeSearchRequest
    {
        public string Vlasnik { get; set; }
        public DateTime DatumBilježenja { get; set; }
        public int KopijaId { get; set; }
    }
}
