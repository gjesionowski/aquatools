using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AquaTools.Models;

namespace AquaTools.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tools()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Volume()
        {
            TankViewModel tvm = new TankViewModel() { Diameter = 0, Height = 0, Width = 0, Length = 0, TankType = ""};
            return View(tvm);
        }
        [HttpPost]
        public IActionResult Volume(TankViewModel tank)
        {
            if (ModelState.IsValid)
            {
                return View("Volume", tank);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
