using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class WishlistStavkaReadService:ReadService<WishlistStavka, Model.WishlistStavka, WishlistStavkaSearchRequest>, IWishlistStavkaReadService
    {
        public WishlistStavkaReadService(knjiznicaContext db, IMapper mapper):base(db,mapper)
        {
        }

        public override List<Model.WishlistStavka> Get(WishlistStavkaSearchRequest search = null)
        {
            var query = _db.WishlisteStavke.Include(x => x.Knjiga).Where(x=>x.Deleted==0 && x.WishlistId == search.WishlistId).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naslov))
                {
                    query = query.Where(x => x.Knjiga.Naslov == search.Naslov);
                }
                if (search.KnjigaId != 0)
                {
                    query = query.Where(x => x.KnjigaId == search.KnjigaId);
                }
                if (search.WishlistId != 0)
                {
                    query = query.Where(x => x.WishlistId == search.WishlistId);
                }
            }

            List<WishlistStavka> stavke = query.ToList();
            return _mapper.Map<List<Model.WishlistStavka>>(stavke);
        }
    }
}
