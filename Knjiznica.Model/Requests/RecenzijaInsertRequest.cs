using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class RecenzijaInsertRequest
    {
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ClanId { get; set; }
        public int KnjigaId { get; set; }
        public DateTime DatumOcjene { get; set; }
    }
}
