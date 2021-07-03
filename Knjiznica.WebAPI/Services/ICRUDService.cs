using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface ICRUDService<T, TModel, TInsert>
    {
        TModel Insert(TInsert insert);
        TModel Update(int id, TInsert update);
        void Delete(int id);
    }
}
