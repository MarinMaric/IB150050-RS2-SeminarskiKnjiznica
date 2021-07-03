using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Stanje
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int KopijaId { get; set; }
        public Kopija Kopija { get; set; }
        public int VlasnikId { get; set; }
        public Clan Vlasnik { get; set; }
        public DateTime DatumBiljezenja { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
