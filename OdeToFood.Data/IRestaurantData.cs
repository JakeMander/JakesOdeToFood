using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurantsByName(string name);
        Restaurant GetRestaurantById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1, Name = "Jake's Pizza", Location = "Burton-Upon-Trent",
                    Cuisine = Restaurant.CuisineType.Italian
                },

                new Restaurant
                {
                    Id = 2, Name = "Chilli IS Spice", Location = "Lichfield",
                    Cuisine = Restaurant.CuisineType.Indian
                },

                new Restaurant
                {
                    Id = 3, Name = "Arribah! Mexican Grub", Location = "Derby",
                    Cuisine = Restaurant.CuisineType.Mexican
                },

                new Restaurant
                {
                    Id = 4, Name = "Je Jah Jees", Location = "Burton-Upon-Trent",
                    Cuisine = Restaurant.CuisineType.Indian
                },

                new Restaurant
                {
                    Id = 5, Name = "Veneziia", Location = "Burton-Upon-Trent",
                    Cuisine = Restaurant.CuisineType.Italian
                },

                new Restaurant
                {
                    Id = 6, Name = "Okra", Location = "Derby",
                    Cuisine =  Restaurant.CuisineType.Indian
                }
            };
        }

        //  Method to Return Our List of Restaurants From The List In A Sorted
        //  By Name Format.
        public IEnumerable<Restaurant> GetAllRestaurantsByName(string name)
        {
            return  from restaurant in _restaurants
                    where string.IsNullOrEmpty(name) || restaurant.Name.StartsWith(name)
                    orderby restaurant.Id
                    select restaurant;

        }

        public Restaurant GetRestaurantById(int id)
        {
            return _restaurants.SingleOrDefault(r => r.Id == id);
        }
    }
}
