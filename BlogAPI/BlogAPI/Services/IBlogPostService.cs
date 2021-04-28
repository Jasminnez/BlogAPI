using BlogAPI.Database;
using BlogAPI.Model;
using BlogAPI.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public interface IBlogPostService : ICRUDService<Model.BlogPost, Database.BlogPost, BlogSearchObject, BlogPostInsertRequest, BlogPostUpdateRequest>
    {
    }
}
