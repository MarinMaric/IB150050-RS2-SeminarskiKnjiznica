using AutoMapper;
using Knjiznica.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Recommender
{
    public class KnjigeRecommender
    {
        knjiznicaContext _db;
        IMapper _mapper;

        Dictionary<int, List<Recenzija>> knjigeDir = new Dictionary<int, List<Recenzija>>();

        public KnjigeRecommender(knjiznicaContext  db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.Knjiga> GetSlicneKnjige(int knjigaId)
        {
            UcitajKnjige(knjigaId);
            List<Recenzija> recenzijePromatraneKnjige = _db.Recenzije.Where(x => x.KnjigaId == knjigaId).OrderBy(x => x.ClanId).ToList();

            List<Recenzija> zajednicke1 = new List<Recenzija>();
            List<Recenzija> zajednicke2 = new List<Recenzija>();

            List<Knjiga> preporuceneKnjige = new List<Knjiga>();

            foreach (var item in knjigeDir)
            {
                foreach (Recenzija r in recenzijePromatraneKnjige)
                {
                    if(item.Value.Where(x=>x.ClanId==r.ClanId).Count() > 0)
                    {
                        zajednicke1.Add(r);
                        zajednicke2.Add(item.Value.Where(x => x.ClanId == r.ClanId).First());
                    }
                }

                double slicnost = GetSlicnost(zajednicke1, zajednicke2);
                if (slicnost > 0.5)
                {
                    Knjiga knjigaDodaj = _db.Knjige.Find(item.Key);
                    preporuceneKnjige.Add(knjigaDodaj);
                }

                zajednicke1.Clear();
                zajednicke2.Clear();
            }

            return _mapper.Map<List<Model.Knjiga>>(preporuceneKnjige);
        }

        double GetSlicnost(List<Recenzija> zajednicke1, List<Recenzija> zajednicke2)
        {
            if (zajednicke1.Count != zajednicke2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;
            for (int i = 0; i < zajednicke1.Count; i++)
            {
                brojnik = zajednicke1[i].Ocjena * zajednicke2[i].Ocjena;
                nazivnik1 = zajednicke1[i].Ocjena * zajednicke1[i].Ocjena;
                nazivnik2 = zajednicke2[i].Ocjena * zajednicke2[i].Ocjena;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        public void UcitajKnjige(int knjigaId)
        {
            List<Knjiga> knjige = _db.Knjige.Where(x => x.Id != knjigaId).ToList();
            List<Recenzija> recenzije;

            foreach (Knjiga k in knjige)
            {
                recenzije = _db.Recenzije.Where(x => x.KnjigaId == k.Id).OrderBy(x => x.ClanId).ToList();
                if (recenzije.Count > 0)
                {
                    knjigeDir.Add(k.Id, recenzije);
                }
            }
        }
    }
}
