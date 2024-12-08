using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class OfficeEmployeeController : Controller
    {
        public IActionResult RegisterEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterEmployee(IFormCollection eform)
        {
            ViewBag.Id = eform["id"];
            ViewBag.Name = eform["name"];
            ViewBag.Email = eform["email"];
            ViewBag.Age = eform["age"];
            ViewBag.Dept = eform["dept"];
            ViewBag.Salary = eform["salary"];
            return View("EmployeeDisplay");
            
        }
    }
}
