using AutoMapper;
using BlogAPI.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Mapping
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Database.BlogPost, Model.BlogPost>();
            CreateMap<Database.BlogPost, Model.Tags>();
            CreateMap<BlogPostInsertRequest, Database.BlogPost>();
            CreateMap<BlogPostUpdateRequest, Database.BlogPost>();
            CreateMap<Database.BlogPost, BlogPostUpdateRequest>();
        }
 
    }
}
