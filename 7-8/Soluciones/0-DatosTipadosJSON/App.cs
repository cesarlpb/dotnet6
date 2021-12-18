using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace ConsoleAppSettings
{
    public class App
    {
        private readonly IConfigurationRoot _config;
        private readonly ILogger<App> _logger;

        public App(IConfigurationRoot config, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<App>();
            _config = config;
        }

        public async Task Run()
        {
            // Fetching the data from appsettings
            List<string> emailAddresses = _config.GetSection("EmailAddresses").Get<List<string>>();
            List<string> strNumbersList = _config.GetSection("Numbers").Get<List<string>>();
            //List<string> jsonList = _config.GetSection("MyObject").Get<List<string>>();
            Dictionary<string,string> jsonDict = _config
                .GetSection("MyObject")
                .Get<Dictionary<string,string>>();
            //string json = JsonConvert.SerializeObject(settings);
            // Passing List<string> elements into List<int>
            List<int> intNumbersList = strNumbersList.Select(int.Parse).ToList();
            
            // Writing the lists
            WriteVariables(emailAddresses, "EmailAddresses");
            WriteVariables(intNumbersList, "Numbers");
            WriteVariables(jsonDict, "MyObject");
            
            //Car newCar = new Car();
            Car newCar = CreateCar();
            _logger.LogInformation(newCar.Name);

            //foreach(var kvp in jsonDict)
            //    _logger.LogInformation("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            
            /*foreach (string emailAddress in emailAddresses)
            {
                _logger.LogInformation("Email address: {@EmailAddress}, tipo: {@tipo}", emailAddress, emailAddress.GetType());
            }*/
        }
        public void WriteVariables<T>(List<T> list, string section){
            foreach (var element in list)
            {
                _logger.LogInformation("{@asdf}: {@variables}, tipo: {@tipos}", section, element, element.GetType());
            }
        }
        public void WriteVariables(Dictionary<string, string> jsonDict, string section){
            foreach(var kvp in jsonDict)
            {
                _logger.LogInformation("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }
        public Car CreateCar(){
            //
            Car newCar = new Car();
            newCar.Name = "asas";
            return newCar;
        }
    }
}
