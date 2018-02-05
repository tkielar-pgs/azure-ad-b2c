using Microsoft.AspNetCore.Mvc;

namespace PGS.Azure.ActiveDirectory.B2C.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
