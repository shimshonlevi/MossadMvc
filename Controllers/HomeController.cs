using Microsoft.AspNetCore.Mvc;
using Mosad1View.Models;
using Mosad1View.ViewModel;
using System.Diagnostics;
using System.Net.Http;

namespace Mosad1View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClientServer _clientServer;

        public HomeController(ILogger<HomeController> logger, ClientServer clientServer)
        {
            _logger = logger;
            _clientServer = clientServer;
        }

        public async Task <IActionResult> Index()
        {
           var agents = await _clientServer.GetAgentsAsync();
           var targets =  await _clientServer.GetTargetsAsync();
           var missions =  await _clientServer.GetMissionsAsync();

           
            var mainView = new MainView(agents, targets, missions);

           
            return View(new List<MainView> { mainView });

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
