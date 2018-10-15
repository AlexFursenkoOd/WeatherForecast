using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherForecast;
using WeatherForecast.Models;
using WeatherForecast.Services;

namespace WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //IForecastService service = new ForecastService();
            //var forecast = await service.GetCurrentForecastByIDAsync(703448).ConfigureAwait(false);
            return View();
        }

        public ActionResult GetForecast(int cityID)
        {
            //IForecastService service = new ForecastService();
            //var forecast = await service.GetCurrentForecastByIDAsync(703448).ConfigureAwait(false);
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}