using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class UplataClanarine
    {
        public int Id { get; set; }
        public int Iznos { get; set; }
        public string Opis { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
