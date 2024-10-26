using LastFmStatistics.Models;
using LastFmStatistics.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LastFmStatistics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICsvParser _csvParser;

        public HomeController(ILogger<HomeController> logger, ICsvParser csvParser)
        {
            _logger = logger;
            _csvParser = csvParser;
        }

        public IActionResult Index()
        {
            var a = _csvParser.GetScrobbles();
            return View(a);
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
