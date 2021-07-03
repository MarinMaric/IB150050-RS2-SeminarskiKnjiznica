using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Kazna
    {
        public int Id { get; set; }
        public int ClanId { get; set; }
        public string ClanIme { get; set; }
        public int PosudbaId { get; set; }
        public int Iznos { get; set; }
        public string Opis { get; set; }
        public string Placeno { get; set; }
        public DateTime Datum { get; set; }
        public string KnjiznicarIme { get; set; }
    }
}
