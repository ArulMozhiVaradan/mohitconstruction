using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MohitConstructionUI.Models;

namespace MohitConstructionUI.Controllers
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

            ViewBag.ActivePage="home";    
            //git : Compuer A Changes
            return View();
        }

        public IActionResult About()
        {
            ViewBag.ActivePage="about";
            return View();
        }

        public IActionResult Services()
        {
            ViewBag.ActivePage="service";
            return View();
        }
        public IActionResult Project()
        {
            ViewBag.ActivePage="project";
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }

         public IActionResult Contact()
        {
            ViewBag.ActivePage="contact";
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
