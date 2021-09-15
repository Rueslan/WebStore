using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from first controller");
        }
        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action wwith parametr {id}");
        }
    }
}
