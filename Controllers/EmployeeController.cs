using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;


namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            ViewData["message"] = "Hello from Controller";
            List<string> names = new List<string>() { "Vishal", "Shivani", "Rohit", "Virat" };

            ViewData["names"]= names;
            ViewBag.Names = names;
            

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=1,Name="Vishal",Dept="IT",Sal=30000},
                new Employee{Id=2,Name="Shivani",Dept="IT",Sal=30000},
                new Employee{Id=3,Name="Rohit",Dept="IT",Sal=30000},
                new Employee{Id=4,Name="Virat",Dept="IT",Sal=30000}

            };

            ViewData["emp"]= emplist;
            ViewBag.Employees = emplist;
            return View();
        }
    }
}
