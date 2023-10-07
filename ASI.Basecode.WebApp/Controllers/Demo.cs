using Microsoft.AspNetCore.Mvc;

namespace ASI.Basecode.WebApp.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students()
        {
            return View();
        }
    }
}
