using Microsoft.AspNetCore.Mvc;

namespace Osrweb.Areas.Web.Controllers
{
    [Area("Web")]
    public class OSR : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet ,Route("/Web/OSR/AboutUs")]
        public async Task<IActionResult> AboutUs()
        {
            return View();
        }
        public async Task<IActionResult> WhyUs()
        {
            return View();
        }
        public async Task<IActionResult> MissionVission()
        {
            return View();
        }
        public async Task<IActionResult> OutTeam()
        {
            return View();
        }
        public async Task<IActionResult> ContactUs()
        {
            return View();
        }
        public async Task<IActionResult> CaseDetails()
        {
            return View();
        }

        public async Task<IActionResult> DevelopmentProcess()
        {
            return View();
        }

        public async Task<IActionResult> Archieve()
        {
            return View();
        }

        public async Task<IActionResult> DigitalMarketing()
        {
            return View();
        }
    }
}
