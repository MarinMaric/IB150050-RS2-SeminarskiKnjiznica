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
    public class UplataController : BaseController<UplataClanarine, Model.UplataClanarine, UplataSearchRequest, UplataInsertRequest>
    {
        public UplataController(IUplataReadService readService, IUplataCRUDService CRUDService):base(readService, CRUDService)
        {

        }

        [HttpPost]
        [Authorize]
        public override Model.UplataClanarine Insert([FromBody] UplataInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public override Model.UplataClanarine Update(int id, [FromBody] UplataInsertRequest update)
        {
            return _CRUDService.Update(id, update);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public override void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
