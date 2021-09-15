using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 29 },
            new Employee { id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 35 },
            new Employee { id = 3, LastName = "Сидоров", FirstName = "Сидр", Patronymic = "Сидорович", Age = 44 }
        };

        public IActionResult Index()
        {
            return View(); 
        }
        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action wwith parametr {id}");
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}
