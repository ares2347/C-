using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class FetchApi
    {
        private readonly string _url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        public async Task<WeatherData> Fetch()
        {
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(_url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    var weather = JsonConvert.DeserializeObject<WeatherData>(res);
                    return weather;
                }
                return null;
            }
            catch(Exception ex) { throw ex; }
        }
    }
}
