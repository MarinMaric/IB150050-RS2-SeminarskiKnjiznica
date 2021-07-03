using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI;
using Microsoft.AspNetCore.Mvc;

namespace Knjiznica.WebAPI.Services
{
    public interface IAutorService
    {
        List<Model.Autor> Get(AutorSearchRequest search);
        Model.Autor Get(int id);
        Model.Autor Insert(AutorInsertRequest insert);
        Model.Autor Update(int id, AutorInsertRequest update);
        void Delete(int id);
    }
}
