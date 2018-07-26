using System;
using Microsoft.AspNetCore.Mvc;

namespace OdeFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello From HommeCOntroller!!!");
        }
    }
}
