﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class Controller : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
