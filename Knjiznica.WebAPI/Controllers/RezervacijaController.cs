using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace Knjiznica.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RezervacijaController : BaseController<Rezervacija, Model.Rezervacija, RezervacijaSearchRequest, RezervacijaInsertRequest>
    {
        public RezervacijaController(IRezervacijaReadService readService, IRezervacijaCRUDService CRUDService) : base(readService, CRUDService)
        {
        }

        [HttpDelete("{id}")]
        [Authorize(Roles ="Admin")]
        public override void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
