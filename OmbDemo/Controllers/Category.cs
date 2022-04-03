using Microsoft.AspNetCore.Mvc;

namespace OmbDemo.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
