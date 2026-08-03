using Microsoft.AspNetCore.Mvc;
using salesMvc.Models;
using System.Diagnostics;
using salesMvc.Models.ViewModels;

namespace salesMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Teste"] = "isso é só um teste";

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
