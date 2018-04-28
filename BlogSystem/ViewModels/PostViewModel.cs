using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSystem.ViewModels
{
    public class PostViewModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}