using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class UplataClanarine
    {
        public int Iznos { get; set; }
        public string Opis { get; set; }
        public string ClanIme { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
