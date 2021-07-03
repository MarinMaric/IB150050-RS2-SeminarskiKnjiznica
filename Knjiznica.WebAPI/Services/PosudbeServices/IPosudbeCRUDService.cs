using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IPosudbeCRUDService:ICRUDService<Posudba, Model.Posudba, PosudbaInsertRequest>
    {
    }
}
