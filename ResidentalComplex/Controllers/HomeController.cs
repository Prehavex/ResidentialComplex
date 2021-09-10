﻿using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ResidentalComplex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddDweller()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDweller(Dweller dweller)
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
