using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services.AutoriServices
{
    public class AutorCRUDService:CRUDService<Autor, Model.Autor, AutorInsertRequest>, IAutorCRUDService
    {
        public AutorCRUDService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {

        }

        public override Model.Autor Insert(AutorInsertRequest insert)
        {
            Autor entity = _mapper.Map<Autor>(insert);
            entity.ImePrezime = insert.Ime + " " + insert.Prezime;
            _db.Set<Autor>().Add(entity);
            _db.SaveChanges();
            Model.Autor returnEntity = _mapper.Map<Model.Autor>(entity);
            return returnEntity;
        }
    }
}
