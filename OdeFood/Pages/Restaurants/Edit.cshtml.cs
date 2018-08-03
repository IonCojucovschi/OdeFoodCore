using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeFood.Mdoels;
using OdeFood.Services;

namespace OdeFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public Restaurant Restaurants { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }


        public IActionResult OnGet(int id)
        {
            Restaurants = _restaurantData.Get(id);
            if (Restaurants == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }
    }
}
