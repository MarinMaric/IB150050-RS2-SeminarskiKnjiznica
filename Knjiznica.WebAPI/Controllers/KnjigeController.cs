using Knjiznica.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.Model.Requests;
using Knjiznica.Database;
using Microsoft.AspNetCore.Authorization;
using Knjiznica.WebAPI.Recommender;

namespace Knjiznica.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnjigeController : BaseController<Knjiga, Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest>
    {
        public KnjigeController(IKnjigeReadService readService, IKnjigeCRUDService CRUDService):base(readService, CRUDService)
        {
        }

        

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public override Model.Knjiga Insert([FromBody] KnjigaInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpPut("{id}")]
        [Authorize(Roles ="Admin")]
        public override Model.Knjiga Update(int id, [FromBody] KnjigaInsertRequest update)
        {
            return _CRUDService.Update(id, update);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles ="Admin")]
        public override void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
