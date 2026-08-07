using Microsoft.AspNetCore.Mvc;
using salesMvc.Services;

namespace salesMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly Services.SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
