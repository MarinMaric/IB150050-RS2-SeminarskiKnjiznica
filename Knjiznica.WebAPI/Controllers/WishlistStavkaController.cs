﻿using Knjiznica.Database;
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
    public class WishlistStavkaController : BaseController<WishlistStavka, Model.WishlistStavka, WishlistStavkaSearchRequest, WishlistStavkaInsertRequest>
    {
        public WishlistStavkaController(IWishlistStavkaReadService readService, IWishlistStavkaCRUDService CRUDService) :base(readService, CRUDService)
        {

        }
    }
}
