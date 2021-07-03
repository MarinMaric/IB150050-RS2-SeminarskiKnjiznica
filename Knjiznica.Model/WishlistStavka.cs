using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class WishlistStavka
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naslov { get; set; }
        public string DostupnoKopija { get; set; }
        public Knjiga DobavljenaKnjiga { get; set; }
    }
}
