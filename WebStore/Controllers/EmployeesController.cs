﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEnumerable<Employee> _Employees;
        public EmployeesController()
        {
            _Employees = TestData.Employees;
        }

        public IActionResult Index => View(_Employees);

        public IActionResult Details(int id)
        {
            var employee = _Employees.SingleOrDefault(e => e.Id == id);
            if (employee is null)
                return NotFound();
            return View(employee);
        }
    }
}
