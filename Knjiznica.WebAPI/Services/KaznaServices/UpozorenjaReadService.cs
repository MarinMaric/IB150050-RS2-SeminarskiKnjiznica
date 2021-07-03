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
    public class UpozorenjaReadService: ReadService<Upozorenje, Model.Upozorenje, UpozorenjeSearchRequest>, IUpozorenjaReadService
    {
        public UpozorenjaReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }
        public override List<Model.Upozorenje> Get(UpozorenjeSearchRequest search)
        {
            var query = _db.Upozorenja.Include(x=>x.Clan).Where(x => x.Deleted == 0).AsQueryable();

            if (search.ClanId > 0)
            {
                query = query.Where(x => x.ClanId == search.ClanId);
            }
            if (!string.IsNullOrEmpty(search.ImePrezime))
            {
                query = query.Where(x => x.Clan.ImePrezime == search.ImePrezime);
            }
            if (!string.IsNullOrEmpty(search.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }
            //if (search.DatumOd > DateTime.MinValue)
            //{
            //    query = query.Where(x => x.DatumPodnosenja >= search.DatumOd);
            //}
            //if (search.DatumOd < DateTime.MaxValue)
            //{
            //    query = query.Where(x => x.DatumPodnosenja <= search.DatumDo);
            //}

            var list = query.ToList();
            return _mapper.Map<List<Model.Upozorenje>>(list);
        }
    }
}
