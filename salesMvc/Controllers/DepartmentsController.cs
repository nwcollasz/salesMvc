using Microsoft.AspNetCore.Mvc;
using salesMvc.Models;
using System.Collections.Generic;

namespace salesMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Computers" },
                new Department { Id = 2, Name = "Electronics" },
                new Department { Id = 3, Name = "Fashion" }
            };

            return View(departments);
        }
    }
}
