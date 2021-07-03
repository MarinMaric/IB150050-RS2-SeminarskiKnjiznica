using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class KaznaInsertRequest
    {
        public int PosudbaId { get; set; }
        public decimal Iznos { get; set; }
        public string Opis { get; set; }
        public int KnjiznicarId { get; set; }
        public DateTime Datum { get; set; }
        public string Placeno { get; set; }
    }
}
