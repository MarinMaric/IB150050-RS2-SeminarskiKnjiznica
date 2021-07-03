using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int ClanId { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
