using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IAProject.Controllers
{
    public class basicController : Controller
    {
        // GET: basic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }



    }
}
