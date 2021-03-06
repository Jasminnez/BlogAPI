using AutoMapper;
using BlogAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseReadService<T, TDb, TSearch>, ICRUDService<T, TDb, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TDb : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(BlogContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual T Delete(string slug)
        {
            throw new NotImplementedException(); //override method
        }

        public virtual T Insert(TInsert request)
        {
            var set = Context.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(request);

            set.Add(entity);

            Context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(string slug, TUpdate request)
        {
            throw new NotImplementedException(); //override method
        }
    }
}
