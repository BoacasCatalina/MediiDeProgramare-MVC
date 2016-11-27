using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoAnAction()
        {
            return Content("hello world");
        } 

        public ActionResult Search()
        {
            return Content("This is Search method for the new route");
        }

        public ActionResult HelloUser(String name)
        {
            return Content("Hello " + name);
        }
    }
}