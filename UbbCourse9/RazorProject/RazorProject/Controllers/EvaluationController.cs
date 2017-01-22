using RazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorProject.Controllers
{
    public class EvaluationController : Controller
    {
        
        public static List<ProjectEvaluation> listOfProjects = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() { city = "Cluj", name = "test", country = "Romania", rating= 2.3 , id = 2},
            new ProjectEvaluation() { city = "Cluj1TEST", name = "test1", country = "Romania1", rating= 2.31, id = 1},
            new ProjectEvaluation() { city = "<script>alert('xss');</script>", name = "test2", country = "Romania2", rating= 2.32, id = 3}
        };


                // GET: Evaluation
        public ActionResult Index()
        {
            return View(listOfProjects);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            var evaluation = listOfProjects.Single(e => e.id == id);
            return View(evaluation);
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var evaluation = listOfProjects.Single(e => e.id == id);
            if(TryUpdateModel(evaluation))
            {
                return RedirectToAction("Index");
            }
            return View(evaluation);
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
