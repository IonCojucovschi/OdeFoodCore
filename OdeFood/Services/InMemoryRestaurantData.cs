using System;
using System.Collections.Generic;
using OdeFood.Mdoels;
using System.Linq;
namespace OdeFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant> {
                new Restaurant{ID=1,Name="Andis PIzza"},
            new Restaurant { ID = 2, Name = "Scot's Pizza" },
            new Restaurant { ID = 3, Name = "LA Placinte" },
                new Restaurant{ID=4,Name="Wagone"}

            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.ID == id);
        }
    }
}
