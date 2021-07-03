using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class StanjeCRUDService:CRUDService<Stanje, Model.Stanje, StanjeInsertRequest>,IStanjeCRUDService
    {
        public StanjeCRUDService(knjiznicaContext db, IMapper mapper):base(db, mapper){
        }
        
        public override Model.Stanje Insert(StanjeInsertRequest insert)
        {
            Stanje stanje = _mapper.Map<Stanje>(insert);
            _db.Stanja.Add(stanje);
            _db.SaveChanges();
            return _mapper.Map<Model.Stanje>(stanje);
        }

        public override Model.Stanje Update(int id, StanjeInsertRequest update)
        {
            Stanje stanje = _db.Stanja.Find(id);
            stanje.Opis = update.Opis;
            _db.SaveChanges();
            return _mapper.Map<Model.Stanje>(stanje);
        }
    }
}
