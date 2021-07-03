using Knjiznica.Model.Requests;
using Knjiznica.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IKnjigeService
    {
        List<Model.Knjiga> Get(KnjigaSearchRequest search);
        List<Model.Kategorija> GetKategorije();
        Model.Knjiga Insert(KnjigaInsertRequest insert);
        Model.Knjiga Update(int id, KnjigaInsertRequest update);
        void Delete(int id);
    }
}
