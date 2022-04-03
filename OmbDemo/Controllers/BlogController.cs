using Microsoft.AspNetCore.Mvc;

namespace OmbDemo.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
