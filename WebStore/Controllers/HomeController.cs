using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 29, Seniority = 1 },
            new Employee { id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 35, Seniority = 4 },
            new Employee { id = 3, LastName = "Сидоров", FirstName = "Сидр", Patronymic = "Сидорович", Age = 44, Seniority = 6 }
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

        public IActionResult CurrentEmployee(int currentId)
        {
            return View("CurrentEmployee", _Employees[currentId - 1]);
        }
    }
}
