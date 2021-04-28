using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseReadController<T, TDb, TSearch> : ControllerBase where T : class where TDb : class where TSearch : class
    {
        protected readonly IBaseReadService<T, TDb, TSearch> _service;
        public BaseReadController(IBaseReadService<T, TDb, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }
      
    }
}
