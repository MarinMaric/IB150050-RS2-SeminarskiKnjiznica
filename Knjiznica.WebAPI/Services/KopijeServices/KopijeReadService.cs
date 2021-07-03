using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.EntityFrameworkCore;

namespace Knjiznica.WebAPI.Services
{
    public class KopijeReadService : ReadService<Kopija, Model.Kopija, KopijaSearchRequest>, IKopijeReadService
    {
        public KopijeReadService(knjiznicaContext db, IMapper mapper) : base(db, mapper){}

        public override List<Model.Kopija> Get(KopijaSearchRequest search = null)
        {
            var query = _db.Kopije.Include(x => x.TrenutniVlasnik).Include(x => x.Knjiga).Where(x=>x.KnjigaId==search.KnjigaId && x.Deleted==0).AsQueryable();

            if (search != null)
            {
                if (search.ID!=0)
                {
                    query = query.Where(x => x.BrojKopije == search.ID);
                }
                if (search.Zauzeta != -1)
                {
                    query = query.Where(x => x.Zauzeta == search.Zauzeta);
                }
            }

            List<Kopija> kopije = query.ToList();
            return _mapper.Map<List<Model.Kopija>>(kopije);
        }
    }
}
