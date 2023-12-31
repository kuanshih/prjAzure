﻿using Microsoft.AspNetCore.Mvc;
using prjAzureVisionAnlyze.Models;
using System.Diagnostics;

namespace prjAzureVisionAnlyze.Controllers
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
        public IActionResult Vision()
        {
            return View();
        }
        public IActionResult VisionImage()
        {
            return View();
        }

        public IActionResult VisionCustom()
        {
            return View();
        }
        public IActionResult LUIS()
        {
            return View();
        }
        public IActionResult contentModerator()
        {
            return View();
        }
        public IActionResult textCheck()
        {
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