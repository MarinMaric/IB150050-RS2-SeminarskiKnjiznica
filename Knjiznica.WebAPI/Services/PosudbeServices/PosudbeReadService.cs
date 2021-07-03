using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class PosudbeReadService : ReadService<Posudba, Model.Posudba, PosudbaSearchRequest>, IPosudbeReadService
    {
        public PosudbeReadService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {

        }

        public override List<Model.Posudba> Get(PosudbaSearchRequest searchRequest=null)
        {
            var query = _db.Posudbe.Include(x=>x.Kopija).ThenInclude(y=>y.Knjiga).Include(x=>x.Clan).Where(x=>x.Deleted==0).AsQueryable();

            if (searchRequest != null)
            {
                if (!String.IsNullOrEmpty(searchRequest.Naslov))
                {
                    query = query.Where(x => x.Kopija.Knjiga.Naslov.Contains(searchRequest.Naslov));
                }

                if (searchRequest.BrojKopije != 0)
                {
                    query = query.Where(x => x.Kopija.BrojKopije == searchRequest.BrojKopije);
                }

                if (searchRequest.ClanId != 0)
                {
                    query = query.Where(x => x.ClanId == searchRequest.ClanId);
                }

                if (!String.IsNullOrEmpty(searchRequest.ClanIme))
                {
                    query = query.Where(x => x.Clan.ImePrezime == searchRequest.ClanIme);
                }

                #region Check ranges

                if (searchRequest.DatumPovrataDo.Year>1990)
                {
                    query = query.Where(x => x.DatumPovrata > searchRequest.DatumPovrataOd && x.DatumPovrata < searchRequest.DatumPovrataDo);
                }
                if (searchRequest.DatumPreuzecaDo.Year > 1990)
                {
                    query = query.Where(x => x.DatumPreuzeca > searchRequest.DatumPreuzecaOd && x.DatumPreuzeca < searchRequest.DatumPreuzecaDo);
                }

                #endregion
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Posudba>>(list);
        }
    }
}
