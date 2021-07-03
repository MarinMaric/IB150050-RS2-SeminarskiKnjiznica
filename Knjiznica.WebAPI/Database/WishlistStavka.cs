using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class WishlistStavka
    {
        public int Id { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
