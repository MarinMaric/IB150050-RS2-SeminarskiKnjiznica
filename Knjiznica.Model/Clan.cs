using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Clan:Korisnik
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public int BrojPosudbi { get; set; }
        public int BrojUpozorenja { get; set; }
        public string Status { get; set; }
        public DateTime DatumUclanjivanja { get; set; }
    }
}
