using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Korisnik
    {
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
