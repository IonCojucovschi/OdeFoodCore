using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using OdeFood.Mdoels;
namespace OdeFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string DayMessage { get; set; }
    }
}
