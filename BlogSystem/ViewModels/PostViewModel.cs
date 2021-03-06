﻿using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogSystem.Common.Mapping;

namespace BlogSystem.ViewModels
{
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}