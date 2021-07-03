using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Upozorenje
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        public string KnjiznicarIme { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
