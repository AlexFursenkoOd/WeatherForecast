using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WeatherForecast.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Forecast
    {
        [XmlElement(ElementName = "City")]
        public City City { get; set; }
        public Wind Wind { get; set; }
        public decimal Humidity { get; set; }
        public int Pressure { get; set; }
        public decimal Temperature { get; set; }
    }

    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class Wind
    {
        public decimal Speed { get; set; }
        public WindDirection Direction { get; set; }
    }

    public class WindDirection
    {
        public decimal Value { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}