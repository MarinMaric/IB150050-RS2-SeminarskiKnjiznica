using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Knjiznica.WebAPI.Services;

namespace Knjiznica.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KaznaController : BaseController<Kazna, Model.Kazna, KaznaSearchRequest, KaznaInsertRequest>
    {
        public KaznaController(IKazneReadService readService, IKazneCRUDService CRUDService):base(readService,CRUDService)
        {

        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public override Model.Kazna Insert([FromBody] KaznaInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public override Model.Kazna Update(int id, [FromBody] KaznaInsertRequest update)
        {
            return _CRUDService.Update(id, update);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public override void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
