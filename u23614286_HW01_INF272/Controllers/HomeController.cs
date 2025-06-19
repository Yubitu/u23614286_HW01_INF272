using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23614286_HW01_INF272.Models;

namespace u23614286_HW01_INF272.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View(ServiceRepository.Services);
        }
    }
}