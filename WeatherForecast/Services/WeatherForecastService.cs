using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient _client;

        public WeatherForecastService()
        {
            _client = new HttpClient();
        }

        public async Task<Forecast> GetCurrentForecastByIDAsync(int cityID)
        {
            var url = Settings.OpenWeather.EndPoint + "/data/2.5/weather?appid=" + Settings.OpenWeather.Key + "&mode=" + Settings.OpenWeather.Mode + "&id=" + cityID;
            var result = await _client.GetAsync(url).ConfigureAwait(false);
            Forecast forecast = null;
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var stream = await result.Content.ReadAsStreamAsync().ConfigureAwait(false);
                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = "current";
                // xRoot.Namespace = "http://www.cpandl.com";
                xRoot.IsNullable = true;
                var xmlSerializer = new XmlSerializer(typeof(Forecast),xRoot);
                forecast = xmlSerializer.Deserialize(stream) as Forecast;
            }
            return forecast;
        }
    }
}