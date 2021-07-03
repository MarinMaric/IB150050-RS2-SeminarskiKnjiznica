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
    [Authorize]
    public class UpozorenjeController : BaseController<Upozorenje, Model.Upozorenje, UpozorenjeSearchRequest, UpozorenjeInsertRequest>
    {
        public UpozorenjeController(IUpozorenjaReadService readService, IUpozorenjaCRUDService CRUDService):base(readService, CRUDService)
        {

        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public override Model.Upozorenje Insert([FromBody] UpozorenjeInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public override Model.Upozorenje Update(int id, [FromBody] UpozorenjeInsertRequest update)
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
