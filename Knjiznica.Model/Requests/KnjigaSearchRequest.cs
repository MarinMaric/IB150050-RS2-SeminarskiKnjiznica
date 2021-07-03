using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class KnjigaSearchRequest
    {
        public string Naslov { get; set; }
        public string Autor{ get; set; }
        public string ISBN { get; set; }
        public int? KategorijaId { get; set; }
        public int? BrojStranicaMin { get; set; }
        public int? BrojStranicaMax { get; set; }
        public int? BrojDostupnihKopijaMin { get; set; }
        public int? BrojDostupnihKopijaMax { get; set; }
        public int? BrojKopijaMin { get; set; }
        public int? BrojKopijaMax { get; set; }
    }
}
