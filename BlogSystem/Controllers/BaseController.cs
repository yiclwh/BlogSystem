﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSystem.Data;

namespace BlogSystem.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController() : this(new BlogSystemData())
        {

        }

        public BaseController(IBlogSystemData data)
        {
            this.Data = data;
        }
        protected IBlogSystemData Data { get; private set; }
    }
}