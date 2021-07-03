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
    public class UplateReadService:ReadService<UplataClanarine, Model.UplataClanarine, UplataSearchRequest>, IUplataReadService
    {
        public UplateReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {

        }

        public override List<Model.UplataClanarine> Get(UplataSearchRequest search)
        {
            var query = _db.Uplate.Include(x=>x.Clan).Where(x => x.Deleted == 0).AsQueryable();

            if (!string.IsNullOrEmpty(search.ClanIme))
            {
                query = query.Where(x => x.Clan.ImePrezime.Contains(search.ClanIme));
            }
            if (search.ClanId > 0)
            {
                query = query.Where(x => x.ClanId == search.ClanId);
            }
            if (search.IznosMin > 0)
            {
                query = query.Where(x => x.Iznos >= search.IznosMin);
            }
            if (search.IznosMax > 0)
            {
                query = query.Where(x => x.Iznos <= search.IznosMax);
            }

            if (search.DatumUplacivanjaOd.Year != DateTime.MinValue.Year)
            {
                query = query.Where(x => x.DatumUplacivanja >= search.DatumUplacivanjaOd);
            }
            if (search.DatumUplacivanjaDo.Year != DateTime.MinValue.Year && search.DatumUplacivanjaDo != DateTime.MaxValue)
            {
                query = query.Where(x => x.DatumUplacivanja <= search.DatumUplacivanjaDo);
            }

            var list = query.ToList().OrderByDescending(x=>x.DatumUplacivanja);
            return _mapper.Map<List<Model.UplataClanarine>>(list);
        }
    }
}
