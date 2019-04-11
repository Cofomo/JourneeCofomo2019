using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookClub.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TheBookClub.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
        private ILogger<HomeController> _logger;

        public HomeController(IConfiguration config, ILogger<HomeController> logger)
        {
            _config = config;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = _config["Bienvenue"];
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

            _logger.LogInformation("logging information from the contact page!");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boom()
        {
            throw new Exception("OMG!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
