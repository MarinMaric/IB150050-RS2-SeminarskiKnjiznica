using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class KnjigaCRUDService:CRUDService<Knjiga, Model.Knjiga, KnjigaInsertRequest>, IKnjigeCRUDService 
    {
        public KnjigaCRUDService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }

        public override void Delete(int id)
        {
            Knjiga entity = _db.Knjige.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
