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
    public class RecenzijeReadService : ReadService<Recenzija, Model.Recenzija, RecenzijaSearchRequest>, IRecenzijeReadService
    {
        public RecenzijeReadService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Recenzija> Get(RecenzijaSearchRequest search)
        {
            var query = _db.Recenzije.Include(x => x.Clan).Include(x => x.Knjiga).Where(x=>x.Deleted==0).AsQueryable();

            if (!String.IsNullOrEmpty(search.Naslov))
            {
                query = query.Where(x => x.Knjiga.Naslov.Contains(search.Naslov));
            }
            if (!String.IsNullOrEmpty(search.Clan))
            {
                query = query.Where(x => x.Clan.ImePrezime.Contains(search.Clan));
            }
            if (search.Ocjena>0)
            {
                query = query.Where(x => x.Ocjena==search.Ocjena);
            }

            return _mapper.Map<List<Model.Recenzija>>(query.ToList());
        }
    }
}
