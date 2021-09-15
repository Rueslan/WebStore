using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action wwith parametr {id}");
        }
    }
}
