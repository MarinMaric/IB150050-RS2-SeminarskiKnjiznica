using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class WishlistStavkaSearchRequest
    {
        public string Naslov { get; set; }
        public int WishlistId { get; set; }
        public int KnjigaId { get; set; }
    }
}
