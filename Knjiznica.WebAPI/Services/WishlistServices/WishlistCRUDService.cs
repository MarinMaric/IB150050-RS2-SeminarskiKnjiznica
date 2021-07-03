using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class WishlistCRUDService: CRUDService<Wishlist, Model.Wishlist, WishlistInsertRequest>, IWishlistCRUDService
    {
        public WishlistCRUDService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
