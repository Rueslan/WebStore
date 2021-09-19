using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 29, Seniority = 1 },
            new Employee { id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 35, Seniority = 4 },
            new Employee { id = 3, LastName = "Сидоров", FirstName = "Сидр", Patronymic = "Сидорович", Age = 44, Seniority = 6 }
        };
    }
}
