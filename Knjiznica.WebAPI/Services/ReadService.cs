using AutoMapper;
using Knjiznica.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class ReadService<T, TModel, TSearch> : IReadService<T, TModel, TSearch> where T:class where TModel:class
    {
        protected readonly knjiznicaContext _db;
        protected readonly IMapper _mapper;
        public ReadService(knjiznicaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _db.Set<T>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel Get(int id)
        {
            var test = _db.Set<T>().Find(id);
            return _mapper.Map<TModel>(test);
        }
    }
}
