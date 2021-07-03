using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Recenzija
    {
        public int Id { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime DatumOcjene { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
