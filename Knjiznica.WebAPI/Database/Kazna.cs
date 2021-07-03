using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Kazna
    {
        public int Id { get; set; }
        public int PosudbaId { get; set; }
        public Posudba Posudba { get; set; }
        public int Iznos { get; set; }
        public string Opis { get; set; }
        public string Placeno { get; set; }
        public DateTime Datum { get; set; }
        public int PropisaoId { get; set; }
        public Knjiznicar Propisao { get; set; }
        public int Deleted { get; set; }
    }
}
