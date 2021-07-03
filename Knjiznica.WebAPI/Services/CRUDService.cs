using AutoMapper;
using Knjiznica.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class CRUDService<T, TModel, TInsert> : ICRUDService<T, TModel, TInsert> where T:class
    {
        protected knjiznicaContext _db;
        protected IMapper _mapper;
        public CRUDService(knjiznicaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public virtual void Delete(int id)
        {
            
        }

        public virtual TModel Insert(TInsert insert)
        {
            T entity = _mapper.Map<T>(insert);
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
            TModel returnEntity = _mapper.Map<TModel>(entity);
            return returnEntity;
        }

        public virtual TModel Update(int id, TInsert update)
        {
            T entity = _db.Set<T>().Find(id);
            _mapper.Map(update, entity);
            _db.SaveChanges();
            TModel returnEntity = _mapper.Map<TModel>(entity);
            return returnEntity;
        }
    }
}
