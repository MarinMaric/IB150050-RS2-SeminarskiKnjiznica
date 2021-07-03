using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Stanje
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public string Vlasnik { get; set; }
        public DateTime DatumBiljezenja { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
