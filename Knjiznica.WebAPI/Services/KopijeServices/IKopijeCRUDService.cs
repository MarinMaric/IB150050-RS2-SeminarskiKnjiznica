using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.Database;
using Knjiznica.Model.Requests;

namespace Knjiznica.WebAPI.Services
{
    public interface IKopijeCRUDService:ICRUDService<Kopija, Model.Kopija, KopijaInsertRequest>
    {
    }
}
