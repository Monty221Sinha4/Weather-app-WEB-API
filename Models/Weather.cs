using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
namespace WeatherApi.Models
{
    public class Weather
    {
        public object GetWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=9d4f5b53afebb4cbf5a9bab392352bab&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;

        }
        
    }
}