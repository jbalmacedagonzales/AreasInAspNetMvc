﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreasInAspNetMvc.Areas.Clients.Controllers
{
    public class HomeController : Controller
    {
        // GET: Clients/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}