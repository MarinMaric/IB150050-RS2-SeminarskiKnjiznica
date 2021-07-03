using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Biografija { get; set; }
        public byte[] Slika { get; set; }
    }
}
