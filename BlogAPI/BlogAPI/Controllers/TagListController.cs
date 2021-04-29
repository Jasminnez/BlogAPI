using BlogAPI.Model;
using BlogAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    public class TagListController : BaseReadController<Model.Tags, Database.BlogPost, object>
    {
        public TagListController(ITagListService service) : base(service)
        {
        }
    }
}
