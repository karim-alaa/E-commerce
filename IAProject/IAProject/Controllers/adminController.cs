using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IAProject.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddGame()
        {
            return View();
        }

        public ActionResult ManageGame()      
        {
            return View();
        }

        public ActionResult ManageArticle()
        {
            return View();
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        public ActionResult ManageCategory()
        {
            return View();
        }

        public ActionResult UpdateCategory()
        {
            return View();
        }

        public ActionResult UpdateArticle()
        {
            return View();
        }

        public ActionResult UpdateGame()
        {
            return View();
        }

        public ActionResult ShowStatistics()
        {
            return View();
        }
    }
}
