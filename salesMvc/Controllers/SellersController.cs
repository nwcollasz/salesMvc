using Microsoft.AspNetCore.Mvc;

namespace salesMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
