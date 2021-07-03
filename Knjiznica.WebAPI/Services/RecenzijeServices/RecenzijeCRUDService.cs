using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;

namespace Knjiznica.WebAPI.Services
{
    public class RecenzijeCRUDService: CRUDService<Recenzija, Model.Recenzija, RecenzijaInsertRequest>,IRecenzijeCRUDService
    {
        public RecenzijeCRUDService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }

        public override Model.Recenzija Insert(RecenzijaInsertRequest insert)
        {
            if(_db.Recenzije.Any(x=>x.ClanId==insert.ClanId && x.KnjigaId == insert.KnjigaId))
            {
                var rec = _db.Recenzije.Where(x => x.ClanId == insert.ClanId && x.KnjigaId == insert.KnjigaId).FirstOrDefault();
                return Update(rec.Id, insert);
            }
            else
            {
                Recenzija entity = _mapper.Map<Recenzija>(insert);
                entity.DatumOcjene = DateTime.Now;
                _db.Recenzije.Add(entity);
                _db.SaveChanges();
                return _mapper.Map<Model.Recenzija>(entity);
            }
        }
        public override void Delete(int id)
        {
            Recenzija entity = _db.Recenzije.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
