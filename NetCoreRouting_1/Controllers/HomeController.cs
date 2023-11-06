using Microsoft.AspNetCore.Mvc;
using NetCoreRouting_1.Models;
using System.Diagnostics;

namespace NetCoreRouting_1.Controllers
{
    //Attribute Based Routing

    [Route("simRoute/[action]")] //İcerideki yer tutuculara dikkat ediniz..Unutmayın ki Attribute Based Routing eger Middleware'de default'ta bir Controller'a denk geliyorsa o sistemi ezer...
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}