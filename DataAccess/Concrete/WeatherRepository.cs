using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public interface IWeatherRepository
    {
        void Add(WeatherModels model);
        void Update(WeatherModels model);
        void Delete(WeatherModels model);
        WeatherModels GetByName(string name);
        WeatherModels FindNewByName(string name);
        List<WeatherModels> GetAll();
    }
    public class WeatherRepository : IWeatherRepository
    {
        static List<WeatherModels> _object = new List<WeatherModels>();

        private string baseurl = "https://api.openweathermap.org/data/2.5/";
        private string apiId;

        private WeatherModels getWeather(string city)
        {
            string url = baseurl + "weather?q=" + city + "&appid=" + apiId + "&lang=tr";
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //string json = (new WebClient()).DownloadString(url);
            WeatherModels weather = new WeatherModels();

            try
            {
                string html;
                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                    weather = JsonConvert.DeserializeObject<WeatherModels>(html);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                    {
                        //Handle it
                    }
                }
                //Handle it
            }

            return weather;
        }

        public WeatherRepository(string api)
        {
            apiId = api;
        }

        public WeatherRepository()
        {
            apiId = "703d6c03284a1b445072d5ddcb73fa94";
        }

        public void Add(WeatherModels model)
        {
           if( _object.FindIndex(x => x.id == model.id)==-1)
            _object.Add(model);
        }

        public void Delete(WeatherModels model)
        {
            _object.Remove(model);
        }

        public List<WeatherModels> GetAll()
        {
            return _object;
        }

        public WeatherModels FindNewByName(string name)
        {
            return getWeather(name);
        }
        public WeatherModels GetByName(string name)
        {
            WeatherModels result = _object.Find(x => x.name == name);
            return result;
        }
        public void Update(WeatherModels model)
        {
            WeatherModels result = _object.Find(x => x.id == model.id);
            _object.Remove(result);
            _object.Add(model);
        }
    }
}
