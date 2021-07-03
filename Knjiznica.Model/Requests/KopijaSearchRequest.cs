using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class KopijaSearchRequest
    {
        public int ID { get; set; }
        public int KnjigaId { get; set; }
        public int Zauzeta { get; set; }
    }
}
