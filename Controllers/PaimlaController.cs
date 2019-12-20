using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class PaimlaController : Controller
    {
        // GET: Paimla
        public ActionResult Search(string country, string food)
        {
            /*var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];

            var message = String.Format("{0}::{1}::{2}::{3}", controller, action, country, food);

            ViewBag.Message = message;*/

            return Content(country + " " + food);
        }
    }
}