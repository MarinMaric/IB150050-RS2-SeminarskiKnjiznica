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
    public class KategorijaController : ControllerBase
    {
        IKnjigeReadService _service;
        public KategorijaController(IKnjigeReadService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Kategorija> Get()
        {
            return _service.GetKategorije();
        }
    }
}
