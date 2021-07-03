using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class WishlistStavkaCRUDService:CRUDService<WishlistStavka, Model.WishlistStavka, WishlistStavkaInsertRequest>, IWishlistStavkaCRUDService
    {
        public WishlistStavkaCRUDService(knjiznicaContext db, IMapper mapper):base(db,mapper)
        {
        }

        public override void Delete(int id)
        {
            WishlistStavka entity = _db.WishlisteStavke.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
