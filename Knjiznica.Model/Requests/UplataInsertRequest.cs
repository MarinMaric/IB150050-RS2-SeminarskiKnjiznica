using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class UplataInsertRequest
    {
        public int Iznos { get; set; }
        public string Opis { get; set; }
        public int ClanId { get; set; }
        public DateTime DatumUplacivanja { get; set; }
    }
}
