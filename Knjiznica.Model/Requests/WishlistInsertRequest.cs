using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class WishlistInsertRequest
    {
        public string Naziv { get; set; }
        public int ClanId { get; set; }
    }
}
