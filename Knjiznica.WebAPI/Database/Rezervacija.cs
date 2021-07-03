using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int StatusId { get; set; }
        public StatusRezervacije Status { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
