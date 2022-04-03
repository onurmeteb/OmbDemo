using Microsoft.AspNetCore.Mvc;

namespace OmbDemo.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
