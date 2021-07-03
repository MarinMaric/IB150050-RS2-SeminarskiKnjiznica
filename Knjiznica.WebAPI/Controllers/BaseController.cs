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
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, TModel, TSearch, TInsert> : ControllerBase 
    {
        protected IReadService<T, TModel, TSearch> _readService;
        protected ICRUDService<T, TModel, TInsert> _CRUDService;
        public BaseController(IReadService<T, TModel, TSearch> readService, ICRUDService<T, TModel, TInsert> CRUDService)
        {
            _readService = readService;
            _CRUDService = CRUDService;
        }
        [HttpGet]
        public virtual List<TModel> Get([FromQuery]TSearch search)
        {
            return _readService.Get(search);
        }

        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _readService.Get(id);
        }

        [HttpPost]
        public virtual TModel Insert([FromBody]TInsert insert)
        {
            return _CRUDService.Insert(insert);
        }
        
        [HttpPut("{id}")]
        [Authorize]
        public virtual TModel Update(int id, [FromBody]TInsert update)
        {
            return _CRUDService.Update(id, update);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public virtual void Delete(int id)
        {
            _CRUDService.Delete(id);
        }
    }
}
