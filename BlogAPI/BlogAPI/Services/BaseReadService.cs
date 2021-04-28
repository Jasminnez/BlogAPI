using AutoMapper;
using BlogAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class BaseReadService<T, TDb, TSearch> : IBaseReadService<T, TDb, TSearch> where T : class where TDb : class where TSearch : class
    {
        public BlogContext Context { get; set; }
        protected readonly IMapper _mapper;
        public BaseReadService(BlogContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<T>();
            var list = entity.ToList();
            return list;
        }
    }
}
