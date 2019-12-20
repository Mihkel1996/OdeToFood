using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        private OdeToFoodDb db = new OdeToFoodDb();
        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                             orderby r.Rating descending
                             select r;

            return PartialView("_Review", bestReview.First());

        }


        //
        // GET: LatestReviews
        public ActionResult LatestReviews()
        {
            var model =
                from r in _reviews
                orderby r.Country
                select r;

            return View(model);
        }
        static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview
            {
                Id = 1,
                Name = "Cinnamon Club",
                City = "London",
                Country="UK",
                Rating = 10,
            },
            new RestaurantReview
            {
                Id = 2,
                Name = "Marrakesh",
                City = "D.C",
                Country = "USA",
                Rating = 10
            },
            new RestaurantReview
            {
                Id = 3,
                Name = "The House of Elliot",
                City = "Ghent",
                Country = "Belgium",
                Rating = 10
            }
        };
        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var restaurant = db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        [HttpGet] 
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit ([Bind(Exclude ="ReviewerName")]RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                var editable_review = db.Reviews.Find(review.Id);
                editable_review.Body = review.Body;
                editable_review.Rating = review.Rating;
                db.Entry(editable_review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = editable_review.RestaurantId });
            }
            return View(review);
        }
        protected override void Dispose(bool disposing)
        {
            if (db!= null) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
        
