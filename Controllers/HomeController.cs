using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Diagnostics;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello, World!";
            return View();
        }
    }
}