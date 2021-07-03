using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class RecenzijaSearchRequest
    {
        public int Ocjena { get; set; }
        public string Clan { get; set; }
        public string Naslov { get; set; }
    }
}
