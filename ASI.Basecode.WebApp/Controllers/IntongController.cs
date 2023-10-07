using Microsoft.AspNetCore.Mvc;

namespace ASI.Basecode.WebApp.Controllers
{
    public class IntongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
