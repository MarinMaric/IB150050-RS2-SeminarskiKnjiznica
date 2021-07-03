using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    //needs Model class, Insert, Search
    public interface IReadService<T, TModel, TSearch>
    {
        List<TModel> Get(TSearch search);
        TModel Get(int id);
    }
}
