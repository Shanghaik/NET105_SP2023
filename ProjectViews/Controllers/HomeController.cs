using API_Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProjectViews.Models;
using ProjectViews.Services;
using System.Diagnostics;

namespace ProjectViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        TServices services = new TServices();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(await services.GetAll<Student>("https://localhost:7167/api/TestAPI/get-all-student"));
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