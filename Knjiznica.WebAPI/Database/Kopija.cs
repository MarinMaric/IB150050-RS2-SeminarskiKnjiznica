using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Kopija
    {
        public int Id { get; set; }
        public int BrojKopije { get; set; }
        public int Zauzeta { get; set; } //0-false
        public int? TrenutniVlasnikId { get; set; }
        public Clan? TrenutniVlasnik { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public List<Stanje> Stanja { get; set; }
        public int Deleted { get; set; }
    }
}
