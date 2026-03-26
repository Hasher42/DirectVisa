using System.Diagnostics;
using DirectVisa.Models;
using Microsoft.AspNetCore.Mvc;

namespace DirectVisa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
        public IActionResult Index2() => View();
        public IActionResult Index3() => View();
        public IActionResult Index4() => View();
        public IActionResult IndexOnePage() => View();
        public IActionResult IndexTwoPage() => View();
        public IActionResult IndexThreePage() => View();
        public IActionResult IndexFourPage() => View();
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult Service() => View();
        public IActionResult ServiceDetails() => View();
        public IActionResult Country() => View();
        public IActionResult CountryDetails() => View();
        public IActionResult Coaching() => View();
        public IActionResult CoachingDetails() => View();
        public IActionResult Team() => View();
        public IActionResult TeamDetails() => View();
        public IActionResult Faq() => View();
        public IActionResult Error404() => View();
        public IActionResult News() => View();
        public IActionResult NewsGrid() => View();
        public IActionResult NewsDetails() => View();

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
