using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IKnjigeReadService:IReadService<Knjiga, Model.Knjiga, KnjigaSearchRequest>
    {
        List<Model.Kategorija> GetKategorije();
        List<Model.Knjiga> Recommend(int Id);
    }
}
