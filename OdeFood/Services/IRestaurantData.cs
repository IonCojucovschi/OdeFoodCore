using System;
using System.Collections;
using System.Collections.Generic;
using OdeFood.Mdoels;
namespace OdeFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
