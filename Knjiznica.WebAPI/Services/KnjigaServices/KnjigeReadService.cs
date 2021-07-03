using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Recommender;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class KnjigeReadService:ReadService<Knjiga, Model.Knjiga, KnjigaSearchRequest>, IKnjigeReadService
    {
        public KnjigeReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }

        public override List<Model.Knjiga> Get(KnjigaSearchRequest search)
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

                if (search.KategorijaId != 0 && search.KategorijaId!=null)
                {
                    knjige = knjige.Where(x => x.KategorijaId == search.KategorijaId);
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
            var rezultati = _mapper.Map<List<Model.Knjiga>>(list);
            foreach(var r in rezultati)
            {
                int count = _db.Recenzije.Where(x => x.KnjigaId == r.Id && x.Deleted == 0).Count();
                if (count > 0)
                {
                    var ocjena = _db.Recenzije.Where(x => x.KnjigaId == r.Id && x.Deleted == 0).Sum(x => x.Ocjena) / count;
                    r.Ocjena = ocjena;
                }
                else
                {
                    r.Ocjena = 0;
                }
            }

            return rezultati;
        }

        public override Model.Knjiga Get(int id){
            var kConvert = _db.Knjige.Include(x=>x.Autor).Where(x => x.Id == id).FirstOrDefault();
            Model.Knjiga knjiga = _mapper.Map<Model.Knjiga>(kConvert);
            int count = _db.Recenzije.Where(x => x.KnjigaId == knjiga.Id && x.Deleted == 0).Count();
            if (count > 0)
            {
                var ocjena = _db.Recenzije.Where(x => x.KnjigaId == knjiga.Id && x.Deleted == 0).Sum(x => x.Ocjena) / count;
                knjiga.Ocjena = ocjena;
            }
            else
            {
                knjiga.Ocjena = 0;
            }
            return _mapper.Map<Model.Knjiga>(knjiga);
        }

        public List<Model.Kategorija> GetKategorije()
        {
            return _mapper.Map<List<Model.Kategorija>>(_db.Kategorije.ToList());
        }

        public List<Model.Knjiga> Recommend(int Id)
        {
            KnjigeRecommender recommender = new KnjigeRecommender(_db, _mapper);
            return recommender.GetSlicneKnjige(Id);
        }
    }
}
