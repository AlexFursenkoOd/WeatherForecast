﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public interface IForecastService
    {
        Task<Forecast> GetCurrentForecastByIDAsync(int cityID);
    }
}