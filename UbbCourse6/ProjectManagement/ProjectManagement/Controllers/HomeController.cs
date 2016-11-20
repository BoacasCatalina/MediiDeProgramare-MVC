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

        public ActionResult CalculateAverage()
        {
            List<int> listOfNumbers = new List<int> { 2, 3, 4, 5, 6, 7, 7, 8, 9, 13 };

            double sumOfListNumbers = listOfNumbers.Sum();
            double averageOfNumbers = sumOfListNumbers / 2;

            return Content("The sum of numbers is: " + sumOfListNumbers + "<br>" + "The average of numbers is: " + averageOfNumbers);
           
        }

        public ActionResult HelloWorld()
        {
            return Content("Hello World");
        }
    }
}