using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Kopija
    {
        public int Id { get; set; }
        public int BrojKopije { get; set; }
        public int Zauzeta { get; set; } //0 -false
        public Knjiga Knjiga { get; set; }
        public Clan PosljednjiVlasnik { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
