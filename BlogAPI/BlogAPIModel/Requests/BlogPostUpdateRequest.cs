using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Model.Requests
{
    public class BlogPostUpdateRequest
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string TagList { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
