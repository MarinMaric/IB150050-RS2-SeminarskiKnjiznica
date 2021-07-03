using Knjiznica.WebAPI.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IPosudbeReadService : IReadService<Posudba, Model.Posudba, PosudbaSearchRequest>
    {
    }
}
