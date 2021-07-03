using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class UplataSearchRequest
    {
        public int ClanId { get; set; }
        public string ClanIme { get; set; }
        public string Opis { get; set; }
        public int IznosMin { get; set; }
        public int IznosMax { get; set; }
        public DateTime DatumUplacivanjaOd { get; set; }
        public DateTime DatumUplacivanjaDo { get; set; }
    }
}
