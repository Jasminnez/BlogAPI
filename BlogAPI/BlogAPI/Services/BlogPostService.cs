using AutoMapper;
using BlogAPI.Database;
using BlogAPI.Model;
using BlogAPI.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class BlogPostService : BaseCRUDService<Model.BlogPost, Database.BlogPost, BlogSearchObject, BlogPostInsertRequest, BlogPostUpdateRequest>, IBlogPostService
    {
        public BlogPostService(BlogContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<Model.BlogPost> Get(BlogSearchObject search = null)
        {
            var entity = Context.Set<Database.BlogPost>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.TagList))
            {
                entity = entity.Where(x => x.TagList.Contains(search.TagList));
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.BlogPost>>(list);
        }
        public override Model.BlogPost Update(string slug, BlogPostUpdateRequest request)
        {
            var set = Context.Set<Database.BlogPost>().AsQueryable();
        
            var entity = set.Where(x => x.Slug == slug);
            
            var list = entity.ToList().Single();
            
            _mapper.Map(request, list);
        
            Context.SaveChanges();
        
            return _mapper.Map<Model.BlogPost>(list);
        }
        public override Model.BlogPost Delete(string slug)
        {
            var set = Context.Set<Database.BlogPost>().AsQueryable();

            var entity = set.Where(x => x.Slug == slug);

            var list = entity.ToList().Single();

            Context.Remove(list);

            Context.SaveChanges();

            return _mapper.Map<Model.BlogPost>(list);
        }
    }
}
