using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcurs7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("about")]
        public ActionResult SomeMethodName()
        {
            return View();
        }

        [NonAction "calcNonAction"]
        public ActionResult Calc()
        {

            return View();
        }

        public ActionResult DisplayCalc()
        {
            return Calc();
        }

        [HttpPost]
        public ActionResult VerbsTest()
        {
            return Content("Hello");
        }

        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello");
        }
    }
}