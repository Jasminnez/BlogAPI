using AutoMapper;
using BlogAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class TagListService : BaseReadService<Model.Tags, Database.BlogPost, object>, ITagListService
    {
        public TagListService(BlogContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
