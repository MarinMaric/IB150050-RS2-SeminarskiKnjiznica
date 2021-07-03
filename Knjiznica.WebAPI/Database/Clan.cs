using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Clan
    {
        public int Id { get; set; }
        public int BrojIskaznice { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Status { get; set; }
        public DateTime DatumUclanjivanja { get; set; }
        public List<UplataClanarine> Uplate { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }
        public List<Posudba> Posudbe { get; set; }
        public List<Recenzija> Recenzije { get; set; }
        public List<Upozorenje> Upozorenja { get; set; }
        public int Deleted { get; set; }
    }
}
