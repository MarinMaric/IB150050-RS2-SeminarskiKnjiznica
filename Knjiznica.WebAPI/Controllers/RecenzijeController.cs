using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Services;
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
    public class RecenzijeController : BaseController<Recenzija, Model.Recenzija, RecenzijaSearchRequest, RecenzijaInsertRequest>
    {
        public RecenzijeController(IRecenzijeReadService readService, IRecenzijeCRUDService CRUDService):base(readService, CRUDService)
        {

        }
    }
}
