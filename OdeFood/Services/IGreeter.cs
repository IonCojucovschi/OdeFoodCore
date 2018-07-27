using Remotion.Linq.Utilities;
using Microsoft.Extensions.Configuration;
namespace OdeFood
{
    public interface IGreeter
    {
        string GetMEsageOfTheDay();
    }
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMEsageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}