using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Database;
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
    public class PosudbaController : BaseController<Posudba, Model.Posudba, PosudbaSearchRequest, PosudbaInsertRequest>
    {
        public PosudbaController(IPosudbeReadService readService, IPosudbeCRUDService CRUDService) : base(readService, CRUDService)
        {
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public override Model.Posudba Insert([FromBody] PosudbaInsertRequest insert)
        {
            return _CRUDService.Insert(insert);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public override Model.Posudba Update(int id, [FromBody] PosudbaInsertRequest update)
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
