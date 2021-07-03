using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class WishlistReadService: ReadService<Wishlist, Model.Wishlist, WishlistSearchRequest>, IWishlistReadService
    {
        public WishlistReadService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Wishlist> Get(WishlistSearchRequest search)
        {
            var query = _db.Wishliste.Where(x => x.Deleted == 0).AsQueryable();
            if (search != null)
            {
                if (search.ClanId != 0)
                    query = query.Where(x => x.ClanId == search.ClanId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Wishlist>>(list);
        }
    }
}
