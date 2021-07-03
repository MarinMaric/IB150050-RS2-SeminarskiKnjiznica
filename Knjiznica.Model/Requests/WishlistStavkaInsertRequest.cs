using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class WishlistStavkaInsertRequest
    {
        public int KnjigaId { get; set; }
        public int WishlistId { get; set; }
    }
}
