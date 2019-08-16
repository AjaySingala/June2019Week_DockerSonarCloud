﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DempApp.Models;
using Microsoft.Extensions.Options;

namespace DempApp.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> settings)
        {
            _appSettings = settings.Value;
        }

        public IActionResult Index()
        {
            ViewData["conn"] = _appSettings.conn;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
