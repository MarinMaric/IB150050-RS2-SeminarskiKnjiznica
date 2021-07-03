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
    public class RecommendController : ControllerBase
    {
        IKnjigeReadService _service;
        public RecommendController(IKnjigeReadService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public List<Model.Knjiga> Recommend(int id)
        {
            return _service.Recommend(id);
        }
    }
}
