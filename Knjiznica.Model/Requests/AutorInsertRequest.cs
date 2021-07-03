using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class AutorInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Biografija { get; set; }
        public byte[] Slika { get; set; }
    }
}
