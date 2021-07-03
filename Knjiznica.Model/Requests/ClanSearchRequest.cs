using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class ClanSearchRequest
    {
        public string Email { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Status { get; set; }
        public int UpozorenjaMin { get; set; }
        public int UpozorenjaMax { get; set; }
        public int PosudbeMin { get; set; }
        public int PosudbeMax { get; set; }
        public int BrojIskaznice { get; set; }
    }
}
