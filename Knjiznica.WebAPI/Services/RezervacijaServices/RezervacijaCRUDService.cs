using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;

namespace Knjiznica.WebAPI.Services
{
    public class RezervacijaCRUDService:CRUDService<Rezervacija, Model.Rezervacija, RezervacijaInsertRequest>, IRezervacijaCRUDService
    {
        public RezervacijaCRUDService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override Model.Rezervacija Insert(RezervacijaInsertRequest insert)
        {
            Rezervacija rezervacija = _mapper.Map<Rezervacija>(insert);
            _db.Add(rezervacija);

            Knjiga k = _db.Knjige.Find(insert.KnjigaId);
            if(k.BrojDostupnihKopija>0)
                k.BrojDostupnihKopija--;

            _db.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(rezervacija);
        }

        public override Model.Rezervacija Update(int id, RezervacijaInsertRequest update)
        {
            Rezervacija rezervacija = _db.Rezervacije.Find(id);
            rezervacija.StatusId = update.StatusId;
            _db.SaveChanges();
            return _mapper.Map<Model.Rezervacija>(rezervacija);
        }

        public override void Delete(int id)
        {
            Rezervacija entity = _db.Rezervacije.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
