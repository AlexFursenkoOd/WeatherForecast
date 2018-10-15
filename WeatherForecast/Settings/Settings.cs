using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecast
{
    public static class Settings
    {
        public static class OpenWeather
        {
            public static readonly string EndPoint = "http://api.openweathermap.org";
            public static readonly string Key = "0a063a4273da60a83d8ef20d5d15f72c";
            public static readonly string Mode = "xml";
        }
        
    }
}