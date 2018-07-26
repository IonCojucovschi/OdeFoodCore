using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace OdeFood.Controllers
{   //  /about
    //[Route("about")]  /// custom controller name 
    //[Route("[controller]/[action]")] ///  default contyrolle name and action 
    // [Route("company/[controller]/[action]")] /// custom route wit not specific link
    public class AboutController
    {
        // [Route("index")]
        public string Index()
        {
            return "Hello from About Controller!!!!";
        }

        /// [Route("address")]   ///customize action
        ///[Route("[action]")]  //// use defaul action 
        public string Address()
        {
            return "MD";
        }
    }
}
