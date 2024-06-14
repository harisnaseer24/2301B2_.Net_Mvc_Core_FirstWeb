using _2301b2firstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2301b2firstWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            TempData.Keep("pname");
            TempData.Keep("description");
            TempData.Keep("price");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }


    }
}