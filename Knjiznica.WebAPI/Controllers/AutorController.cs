using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Services;
using Knjiznica.WebAPI.Services.AutoriServices;
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
    [Authorize]
    public class AutorController : BaseController<Autor, Model.Autor, AutorSearchRequest, AutorInsertRequest>
    {

        public AutorController(IAutorReadService readService, IAutorCRUDService CRUDService):base(readService, CRUDService)
        {
           
        }

        [HttpGet]
        public override List<Model.Autor> Get(AutorSearchRequest search)
        {
            return _readService.Get(search);
        }
    }
}
