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
    public class KopijeCRUDService:CRUDService<Kopija, Model.Kopija, KopijaInsertRequest>, IKopijeCRUDService
    {
        public KopijeCRUDService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }
        
        public override Model.Kopija Insert(KopijaInsertRequest insert)
        {
            int brKopije;
            if(_db.Kopije.Any(x => x.KnjigaId == insert.KnjigaId))
                brKopije = _db.Kopije.Where(x => x.KnjigaId == insert.KnjigaId).Max(x => x.BrojKopije);
            else brKopije = 0;
            Kopija kopija = _mapper.Map<Kopija>(insert);
            kopija.Knjiga = _db.Knjige.Find(insert.KnjigaId);
            kopija.Stanja = new List<Stanje>();
            kopija.BrojKopije = brKopije+1;
            _db.Add<Kopija>(kopija);

            _db.Knjige.Find(kopija.KnjigaId).BrojKopija++;
            _db.Knjige.Find(kopija.KnjigaId).BrojDostupnihKopija++;
            _db.SaveChanges();

            return _mapper.Map<Model.Kopija>(kopija);
        }

        public override Model.Kopija Update(int id, KopijaInsertRequest insert)
        {
            Kopija kopija = _db.Kopije.Find(id);
            if (insert.Zauzeta != kopija.Zauzeta)
            {
                Knjiga k = _db.Knjige.Find(kopija.KnjigaId);
                if (insert.Zauzeta == 0)
                    kopija.Knjiga.BrojDostupnihKopija++;

                kopija.Zauzeta = insert.Zauzeta;
            }

            if (_db.Clanovi.Any(x=>x.Id == insert.ClanId))
                kopija.TrenutniVlasnikId = insert.ClanId;
            _db.SaveChanges();
            return _mapper.Map<Model.Kopija>(kopija);
        }

        public override void Delete(int id)
        {
            Kopija entity = _db.Kopije.Find(id);
            if (entity.Zauzeta == 0)
            {
                Knjiga k = _db.Knjige.Find(entity.KnjigaId);
                k.BrojDostupnihKopija--;
                k.BrojKopija--;
            }
            else { return; }
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
