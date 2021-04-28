using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public interface IBaseReadService<T, TDb, TSearch> where T: class where TDb : class where TSearch: class
    {
        IEnumerable<T> Get(TSearch search = null);
    }
}
