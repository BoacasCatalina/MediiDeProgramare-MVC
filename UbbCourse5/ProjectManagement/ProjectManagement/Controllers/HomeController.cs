using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           // ViewBag.Message = "Your application description page.";
            //ViewBag.Author = "Catalina Boacas";
            var model = new AboutModel();
            model.Message = "Your application description page. Test";
            model.Author = "Catalina Boacas";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}