using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services.AutoriServices
{
    public class AutorReadService:ReadService<Autor, Model.Autor, AutorSearchRequest>, IAutorReadService
    {
        public AutorReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
           
        }

        public override List<Model.Autor> Get(AutorSearchRequest search = null)
        {
            List<Autor> list;
            if (search == null || string.IsNullOrEmpty(search.ImePrezime))
                list= _db.Autori.Where(x => x.Deleted == 0).ToList();
            else
                list=_db.Autori.Where(x => x.ImePrezime.Contains(search.ImePrezime) ||x.ImePrezime==search.ImePrezime).ToList();
            return _mapper.Map<List<Model.Autor>>(list);
        }

    }
}
