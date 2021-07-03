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
    public class StanjeReadService:ReadService<Stanje, Model.Stanje, StanjeSearchRequest>, IStanjeReadService
    {
        public StanjeReadService(knjiznicaContext db, IMapper mapper):base(db, mapper){}

        public override List<Model.Stanje> Get(StanjeSearchRequest search = null)
        {
            var query = _db.Stanja.Include(x=>x.Vlasnik).Where(x=>x.KopijaId==search.KopijaId).Where(x=>x.Deleted==0).AsQueryable();
            
            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Vlasnik))
                {
                    query = query.Where(x => x.Vlasnik.ImePrezime.Contains(search.Vlasnik));
                }
            }

            return _mapper.Map<List<Model.Stanje>>(query.ToList());
        }
    }
}
