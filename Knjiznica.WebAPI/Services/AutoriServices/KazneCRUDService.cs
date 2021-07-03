using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services.AutoriServices
{
    public class KazneCRUDService:CRUDService<Kazna, Model.Kazna, KaznaInsertRequest>, IKazneCRUDService
    {
        public KazneCRUDService(knjiznicaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override Model.Kazna Insert(KaznaInsertRequest insert)
        {
            Kazna entity = _mapper.Map<Kazna>(insert);
            entity.PropisaoId = insert.KnjiznicarId;
            entity.Placeno = "Ne";

            _db.Set<Kazna>().Add(entity);
            _db.SaveChanges();
            Model.Kazna returnEntity = _mapper.Map<Model.Kazna>(entity);
            return returnEntity;
        }

        public override void Delete(int id)
        {
            Kazna entity = _db.Kazne.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
        }
    }
}
