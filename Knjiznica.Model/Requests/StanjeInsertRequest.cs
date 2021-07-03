using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class StanjeInsertRequest
    {
        public string Opis { get; set; }
        public int VlasnikId { get; set; }
        //public Clan Vlasnik { get; set; }
        public DateTime DatumBiljezenja { get; set; }
        public int KopijaId { get; set; }
        //public Kopija Kopija { get; set; }
    }
}
