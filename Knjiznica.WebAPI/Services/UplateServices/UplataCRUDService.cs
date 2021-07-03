using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class UplataCRUDService: CRUDService<UplataClanarine, Model.UplataClanarine, UplataInsertRequest>, IUplataCRUDService
    {
        public UplataCRUDService(knjiznicaContext db, IMapper mapper):base(db,mapper)
        {

        }
        public override void Delete(int id)
        {
            UplataClanarine entity = _db.Uplate.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
