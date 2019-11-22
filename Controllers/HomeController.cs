using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start yourASP.NET MVC application.";
            return View();
        }

        public ActionResult About()
        {
            var Model = new AboutModel();
            Model.Name = "Mihkel";
            Model.Age = "22";
            Model.Location = "Tallinn, Estonia";
            return View(Model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}