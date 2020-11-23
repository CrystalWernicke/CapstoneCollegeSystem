using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollegeSystem.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.StateProcessor;

namespace CollegeSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewState()
        {
            ViewBag.Message = "State List";

            var data = LoadStates();
            List<StatesModel> states = new List<StatesModel>();

            foreach (var row in data)
            {
                states.Add(new StatesModel()
                {
                    StateId = row.StateId,
                    StateName = row.StateName,
                    StateCode = row.StateCode
                });
            }

            return View(states);
        }

        public ActionResult AddState()
        {
            ViewBag.Message = "Add States";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddState(StatesModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateState(model.StateId, 
                    model.StateName, 
                    model.StateCode);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}