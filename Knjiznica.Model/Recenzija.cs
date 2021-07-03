using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Recenzija
    {
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public string Clan { get; set; }
        public string KnjigaNaslov { get; set; }
        public DateTime DatumOcjene { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
