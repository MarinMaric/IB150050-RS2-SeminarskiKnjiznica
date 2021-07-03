using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class UpozorenjeInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int ClanId { get; set; }
        public int KnjiznicarId { get; set; }
        public DateTime DatumPodnosenja { get; set; }
    }
}
