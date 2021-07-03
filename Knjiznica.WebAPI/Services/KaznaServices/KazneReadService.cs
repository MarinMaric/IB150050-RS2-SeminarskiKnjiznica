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
    public class KazneReadService:ReadService<Kazna, Model.Kazna, KaznaSearchRequest>, IKazneReadService
    {
        public KazneReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }

        public override List<Model.Kazna> Get(KaznaSearchRequest search)
        {
            var query = _db.Kazne.Include(x=>x.Posudba).Where(x=>x.Deleted==0).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Placeno))
                {
                    query = query.Where(x => x.Placeno == search.Placeno);
                }
                if (search.ClanId>0)
                {
                    query = query.Where(x => x.Posudba.ClanId == search.ClanId);
                }
                if (search.Iznos > 0)
                {
                    query = query.Where(x => x.Iznos == search.Iznos);
                }
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Kazna>>(list);
        }
    }
}
