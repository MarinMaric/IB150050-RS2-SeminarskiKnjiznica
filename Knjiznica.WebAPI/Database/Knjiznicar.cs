using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Knjiznicar
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DatumZaposljavanja { get; set; }
        public DateTime? DatumOstavke { get; set; }
        public int Deleted { get; set; }
    }
}
