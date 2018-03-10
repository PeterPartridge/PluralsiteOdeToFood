using Microsoft.Extensions.Configuration;

namespace PluralsiteOdeToFood
{
    public interface IGreeter
    {
        string MessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string MessageOfTheDay()
        {
            //return "Greetings Human";
            return _configuration["Greeting"];
        }
    }
}