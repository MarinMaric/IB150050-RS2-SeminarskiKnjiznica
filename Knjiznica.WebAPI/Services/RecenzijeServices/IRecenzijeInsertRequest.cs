using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IRecenzijeCRUDService: ICRUDService<Recenzija, Model.Recenzija, RecenzijaInsertRequest>
    {

    }
}
