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
        public ActionResult Found(string country, string food)
        {
            return Content(country, food);
        }
    }
}