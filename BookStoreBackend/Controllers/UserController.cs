using Microsoft.AspNetCore.Mvc;

namespace BookStoreBackend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
