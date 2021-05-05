using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreasInAspNetMvc.Areas.Employees.Controllers
{
    public class HomeController : Controller
    {
        // GET: Employees/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}