using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class PosudbaSearchRequest
    {
        public string Naslov { get; set; }
        public int BrojKopije { get; set; }
        public int ClanId { get; set; }
        public string ClanIme { get; set; }
        public DateTime DatumPreuzecaOd { get; set; }
        public DateTime DatumPreuzecaDo { get; set; }
        public DateTime DatumPovrataOd { get; set; }
        public DateTime DatumPovrataDo { get; set; }
    }
}
