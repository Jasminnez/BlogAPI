using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    public class BaseCRUDController<T, TDb, TSearch, TInsert, TUpdate> : BaseReadController<T, TDb, TSearch> where T : class where TDb : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TDb, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TDb, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }
        [HttpPost]
        public T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _crudService.Update(id, request);
        }
    }
}
