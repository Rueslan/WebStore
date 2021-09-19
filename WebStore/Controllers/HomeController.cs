using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetIndex()
        {
            return View();
        }

        //public IActionResult CurrentEmployee(int currentId)
        // {
        //     return View("CurrentEmployee", _Employees[currentId - 1]);
        //}
    }
}
