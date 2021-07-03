using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class KopijaInsertRequest
    {
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public int Zauzeta { get; set; } //0-false
        public int ClanId { get; set; }
    }
}
