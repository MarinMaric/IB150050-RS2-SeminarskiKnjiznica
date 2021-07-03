using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class PosudbeCRUDService : CRUDService<Posudba, Model.Posudba, PosudbaInsertRequest>, IPosudbeCRUDService
    {
        public PosudbeCRUDService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {

        }

        public override void Delete(int id)
        {
            Posudba entity = _db.Posudbe.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
