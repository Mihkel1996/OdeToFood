﻿namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //context.Restaurants.AddOrUpdate(r => r.Name,
            //new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
            //new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
            //new Restaurant
            //{
            //    Name = "Smaka",
            //    City = "Gothenburg",
            //    Country = "Sweden",
            //    Reviews =
            //    new List<RestaurantReview> {
            //    new RestaurantReview {Rating = 9, Body="Great food!",}
            //    }

            //});
            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                   new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }
        }
    }
}
