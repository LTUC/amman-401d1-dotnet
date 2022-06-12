using Microsoft.AspNetCore.Mvc;

namespace RazorPagesDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
