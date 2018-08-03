using System;
using OdeFood.Mdoels;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OdeFood.ViewModels
{
    public class RestaurantEditMdoel
    {
        [Required, MaxLength(10)]
        public string Name { get; set; }
        public CuisineType foodType { get; set; }
    }
}
