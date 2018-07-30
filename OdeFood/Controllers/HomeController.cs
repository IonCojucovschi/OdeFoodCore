using System;
using Microsoft.AspNetCore.Mvc;
using OdeFood.Mdoels;
using OdeFood.Services;
using OdeFood.ViewModels;
using Remotion.Linq.Utilities;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OdeFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;
        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }



        public IActionResult Index()
        {
            var model = new HomeIndexViewModel { Restaurants = _restaurantData.GetAll(), DayMessage = _greeter.GetMEsageOfTheDay() };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);



            if (model == null)
            {
                return RedirectToAction(nameof(Index));
                ///return NotFound();/// return an requesst error with code 404
            }
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
