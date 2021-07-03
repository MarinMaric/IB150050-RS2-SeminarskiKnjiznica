using Knjiznica.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Database
{
    public class Posudba
    {
        public int Id { get; set; }
        public int KopijaId { get; set; }
        public Kopija Kopija { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumPreuzeca { get; set; }
        public DateTime DatumPovrata { get; set; }
        public int Deleted { get; set; }

    }
}
