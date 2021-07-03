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
    public class WishlistController : BaseController<Wishlist, Model.Wishlist, WishlistSearchRequest, WishlistInsertRequest>
    {
        public WishlistController(IWishlistReadService readService, IWishlistCRUDService CRUDService) : base(readService, CRUDService)
        {
        }

        [HttpGet]
        [Authorize]
        public override List<Model.Wishlist> Get([FromQuery] WishlistSearchRequest search =null)
        {
            return _readService.Get(search);
        }
    }
}
