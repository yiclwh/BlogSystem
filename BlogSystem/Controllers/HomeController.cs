using BlogSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSystem.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var posts = this.Data.Posts
                .All()
                .Select(p => new PostViewModel()
                {
                    Author = p.Author.UserName,
                    Content = p.Content,
                    Title = p.Title,
                    CreatedOn = DateTime.Now
                })
                .ToList();
            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}