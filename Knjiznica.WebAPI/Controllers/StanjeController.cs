using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles="Admin")]
    public class StanjeController : BaseController<Stanje, Model.Stanje, StanjeSearchRequest, StanjeInsertRequest>
    {
        public StanjeController(IStanjeReadService readService, IStanjeCRUDService CRUDService):base(readService, CRUDService)
        {
        }
    }
}
