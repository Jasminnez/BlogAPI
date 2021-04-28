using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
     public interface ICRUDService<T,TDb, TSearch, TInsert, TUpdate> : IBaseReadService<T, TDb, TSearch> where T : class where TDb : class where TSearch : class where TInsert : class where TUpdate : class 
     {
         T Insert(TInsert request);
         T Update(int id, TUpdate request);
     }
   
}
