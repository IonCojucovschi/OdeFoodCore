using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeFood.Services;

namespace OdeFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;
        public string CurrentGreeter { get; set; }


        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet(string name)
        {
            CurrentGreeter = $"{name}: {_greeter.GetMEsageOfTheDay()}";
        }
    }
}
