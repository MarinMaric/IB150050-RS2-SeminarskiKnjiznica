using System;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Knjiznica.WebAPI.Services
{
    public class RezervacijaReadService : ReadService<Rezervacija, Model.Rezervacija, RezervacijaSearchRequest>, IRezervacijaReadService
    {
        public RezervacijaReadService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public List<Model.Rezervacija> Get(RezervacijaSearchRequest search)
        {
            var query = _db.Rezervacije.Include(x => x.Clan).Include(x => x.Knjiga).Include(x => x.Status).Where(x => x.Deleted == 0).AsQueryable();

            if (search != null)
            {
                if (search.ClanId != 0)
                {
                    query = query.Where(x => x.ClanId == search.ClanId);
                }
                if (!string.IsNullOrEmpty(search.Naslov))
                {
                    query = query.Where(x => x.Knjiga.Naslov.Contains(search.Naslov));
                }
                if (!string.IsNullOrEmpty(search.ImePrezime))
                {
                    query = query.Where(x => x.Clan.ImePrezime.Contains(search.ImePrezime));
                }
                var test = DateTime.MinValue;
                #region Check ranges

                if (search.DatumRezervacijeOd.Year != DateTime.MinValue.Year)
                {
                    query = query.Where(x => x.DatumRezervacije >= search.DatumRezervacijeOd);
                }
                if (search.DatumRezervacijeDo.Year != DateTime.MinValue.Year)
                {
                    query = query.Where(x => x.DatumRezervacije <= search.DatumRezervacijeDo);
                }

                #endregion
            }

            List<Rezervacija> list = query.ToList();
            return _mapper.Map<List<Model.Rezervacija>>(list);
        }
        public Model.Rezervacija Get(int id)
        {
            var r = _db.Rezervacije.Include(x => x.Knjiga).Include(x=>x.Status).Where(x => x.Id == id).First();
            return _mapper.Map<Model.Rezervacija>(r);
        }
    }
}