using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public int KnjigaId { get; set; }
        public int ClanId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int StatusId { get; set; }
    }
}
