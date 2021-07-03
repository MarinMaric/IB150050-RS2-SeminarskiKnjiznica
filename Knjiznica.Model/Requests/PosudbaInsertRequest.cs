using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class PosudbaInsertRequest
    {
        public int RezervacijaId { get; set; }
        public int KopijaId { get; set; }
        public DateTime DatumPreuzeca { get; set; }
        public DateTime DatumPovrata { get; set; }
        public int KnjigaId { get; set; }
        public int ClanId { get; set; }
    }
}
