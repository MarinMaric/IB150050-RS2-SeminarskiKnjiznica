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
    public class ClanController : BaseController<Clan, Model.Clan, ClanSearchRequest, ClanInsertRequest>
    {
        public ClanController(IClanReadService readService, IClanCRUDService CRUDService) : base(readService, CRUDService)
        {
        }

        [HttpPost]
        public override Model.Clan Insert([FromBody] ClanInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles ="Admin")]
        public override void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
