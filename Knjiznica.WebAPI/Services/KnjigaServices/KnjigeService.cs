using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Knjiznica.WebAPI.Services
{
    public class KnjigeService : IKnjigeService
    {
        knjiznicaContext _db;
        IMapper _mapper;

        public KnjigeService(knjiznicaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.Knjiga> Get(KnjigaSearchRequest search=null)
        {
            var knjige = _db.Knjige.Include(x=>x.Autor).Where(x=>x.Deleted==0).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naslov))
                {
                    knjige = knjige.Where(x => x.Naslov.Contains(search.Naslov));
                }
                if (!string.IsNullOrEmpty(search.Autor))
                {
                    knjige = knjige.Where(x => x.Autor.ImePrezime.Contains(search.Autor));
                }
                if (!string.IsNullOrEmpty(search.ISBN))
                {
                    knjige = knjige.Where(x => x.ISBN == search.ISBN);
                }

                #region Check ranges
                if (!search.BrojStranicaMin.HasValue)
                {
                    search.BrojStranicaMin = int.MinValue;
                }
                if (!search.BrojStranicaMax.HasValue)
                {
                    search.BrojStranicaMax = int.MaxValue;
                }
                knjige = knjige.Where(x => x.BrojStranica >= search.BrojStranicaMin && x.BrojStranica <= search.BrojStranicaMax);

                if (!search.BrojDostupnihKopijaMin.HasValue)
                {
                    search.BrojDostupnihKopijaMin = int.MinValue;
                }
                if (!search.BrojDostupnihKopijaMax.HasValue)
                {
                    search.BrojDostupnihKopijaMax = int.MaxValue;
                }
                knjige = knjige.Where(x => x.BrojDostupnihKopija >= search.BrojDostupnihKopijaMin && x.BrojKopija <= search.BrojDostupnihKopijaMax);

                if (!search.BrojKopijaMin.HasValue)
                {
                    search.BrojKopijaMin = int.MinValue;
                }
                if (!search.BrojKopijaMax.HasValue)
                {
                    search.BrojKopijaMax = int.MaxValue;
                }
                knjige = knjige.Where(x => x.BrojKopija >= search.BrojKopijaMin && x.BrojKopija <= search.BrojKopijaMax);
                #endregion
            }

            List<Knjiga> list = knjige.ToList();
            return _mapper.Map<List<Model.Knjiga>>(list);
        }

        public List<Model.Kategorija> GetKategorije()
        {
            return _mapper.Map<List<Model.Kategorija>>(_db.Kategorije.ToList());
        }

        public Model.Knjiga Insert(KnjigaInsertRequest insert)
        {
            Knjiga knjiga = _mapper.Map<Knjiga>(insert);
            knjiga.BrojDostupnihKopija = insert.BrojKopija;
            _db.Knjige.Add(knjiga);
            _db.SaveChanges();

            return _mapper.Map<Model.Knjiga>(knjiga);
        }

        public Model.Knjiga Update(int id, KnjigaInsertRequest update)
        {
            Knjiga knjiga = _db.Knjige.First(x => x.Id == id);
            _mapper.Map(update, knjiga);
            _db.SaveChanges();

            return _mapper.Map<Model.Knjiga>(knjiga);
        }

        public void Delete(int id)
        {
            Knjiga knjiga = _db.Knjige.First(x => x.Id == id);
            _db.Knjige.Remove(knjiga);
            _db.SaveChanges();
        }
    }
}
