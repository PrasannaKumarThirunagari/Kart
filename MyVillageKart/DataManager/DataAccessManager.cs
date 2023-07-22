using Rest;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System;
using Newtonsoft.Json;

namespace MyVillageKart.DataManager
{
    public class DataAccessManager
    {
        private const string URL = "WeatherForecast";
        private string urlParameters = "?api_key=123";
        public List<string> Getuser()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7141/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                //GET Method
                var response = client.GetAsync("https://localhost:7141/WeatherForecast").Result;
                if (response.IsSuccessStatusCode)
                {
                    var department = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<string>>(department);

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                    return new List<string>();
                }
            }
        }
    }
}
