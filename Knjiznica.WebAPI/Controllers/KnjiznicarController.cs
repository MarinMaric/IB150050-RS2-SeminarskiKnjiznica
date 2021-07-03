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
    public class KnjiznicarController :ControllerBase
    {
        IKorisnikService _korisnikService;

        public KnjiznicarController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpPost]
        public void Insert([FromBody] KnjiznicarInsertRequest insert)
        {
            _korisnikService.Register(insert);
        }

        [HttpGet]
        public List<Model.Knjiznicar> Get([FromQuery] KnjiznicarSearchRequest search)
        {
            return _korisnikService.Get(search);
        }
    }
}
