﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public interface ITagListService : IBaseReadService<Model.Tags, Database.BlogPost, object>
    {
    }
}
