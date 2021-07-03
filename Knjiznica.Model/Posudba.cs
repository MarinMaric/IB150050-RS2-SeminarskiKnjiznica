using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Posudba
    {
        public int Id { get; set; }
        public string ClanIme { get; set; }
        public int BrojKopije { get; set; }
        public DateTime DatumPreuzeca { get; set; }
        public DateTime DatumPovrata { get; set; }
        public string Naslov { get; set; }
        public string Ocjena { get; set; }
        public byte[] Slika { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
