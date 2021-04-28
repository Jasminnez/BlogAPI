using BlogAPI.Database;
using BlogAPI.Services;
using BlogAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Model.Requests;

namespace BlogAPI.Controllers
{
    public class BlogPostController : BaseCRUDController<Model.BlogPost, Database.BlogPost,  BlogSearchObject, BlogPostInsertRequest, BlogPostUpdateRequest>
    {
        public BlogPostController(IBlogPostService service) : base(service)
        {
        }
    }
}
