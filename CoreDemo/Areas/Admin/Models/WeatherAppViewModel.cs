using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoreDemo.Areas.Admin.Models
{
    /// <summary>
    /// WeatherApp üzerinden gelecek olan JSON , nesne içerisine alır.
    /// </summary>
    public class WeatherAppViewModel
    {
        [JsonProperty(PropertyName = "main")]
        public JObject TemperatureJson { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public JArray WeatherJson { get; set; }

        public WeatherAppMainObject TemperatureObject { get; set; }
        public WeatherAppWeatherObject[] WeatherObjects { get; set; }
    }

    public class WeatherAppMainObject
    {
        [JsonProperty(PropertyName = "temp")]
        public string Temperature { get; set; }

        [JsonProperty(PropertyName = "feels_like")]
        public string FeltTemperature { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public string MinTemperature { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public string MaxTemperature { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public string Pressure { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public string Humidity { get; set; }
    }

    public class WeatherAppWeatherObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "main")]
        public string Main { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }
    }
}
