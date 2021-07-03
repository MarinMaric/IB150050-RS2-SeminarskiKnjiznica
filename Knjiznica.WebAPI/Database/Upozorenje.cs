using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Upozorenje
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KnjiznicarId { get; set; }
        public Knjiznicar Knjiznicar { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
