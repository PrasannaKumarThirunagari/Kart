using Microsoft.AspNetCore.Mvc;
using MyVillageKart.DataManager;
using MyVillageKart.Models;
using System.Diagnostics;

namespace MyVillageKart.Controllers
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
            DataAccessManager data = new DataAccessManager();
            var response = data.Getuser();
            ViewBag.Data = response;

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