using Microsoft.AspNetCore.Mvc;

namespace BookStoreBackend.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
