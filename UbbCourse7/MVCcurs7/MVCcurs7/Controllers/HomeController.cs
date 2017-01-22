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

        [NonAction]
        public ActionResult Calc()
        {
            return View();
        }

        public ActionResult DisplayCalc()
        {
            return Calc();
        }

       // [HttpPost]
       [HttpGet]
        public ActionResult VerbsTest()
        {
            return Content("Hello VerbsTest");
        }
        //[Authorize(Roles="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello ThisMethodNeedsAuthorization");
        }
    }
}