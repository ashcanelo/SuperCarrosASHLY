using Microsoft.AspNetCore.Mvc;
using SuperCarrosASH.Models;
using System.Diagnostics;

namespace SuperCarrosASH.Controllers
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
            using (dqca5vecjcv9vContext bd = new dqca5vecjcv9vContext())
            {
                var carros = bd.Carros.ToList();
                return View(carros.ToList());   
            }
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