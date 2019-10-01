using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Weather()
        {
            return View();
        }
        public ActionResult WeatherInfo()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Weather weath = new Weather();

            return Json(weath.GetWeather(),JsonRequestBehavior.AllowGet);
        }
    }
}