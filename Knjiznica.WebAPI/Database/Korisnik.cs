using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Database
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int TipKorisnikaId { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
    }
}
