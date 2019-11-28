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
        public ActionResult Search(string Country, string Food)
        {
            return Content(Country, Food);
        }
    }
}