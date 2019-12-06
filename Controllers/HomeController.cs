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
        OdeToFoodDb _db = new OdeToFoodDb();
        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();

            return View(model);
            /*ViewBag.Message = "Modify this template to jump-start yourASP.NET MVC application.";
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            ViewBag.Message = $"{controller} :: {action} - {id}";
            return View();*/
        }

        public ActionResult About()
        {
            var Model = new AboutModel();
            Model.Name = "Mihkel";
            Model.Age = 22;
            Model.Location = "Tallinn, Estonia";
            return View(Model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}