using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentDetails()
        {
            List<string> branch = new List<string>() { "CSE","IT","Mech","Civil"};
            ViewData["branch"]=new SelectList(branch);

            
            return View();
        }

        [HttpPost]
        public IActionResult StudentDetails(IFormCollection sform)
        {
            ViewBag.RollNo = sform["rollno"];
            ViewBag.Name=sform["name"];
            ViewBag.Branch = sform["branch"];
            ViewBag.Year = sform["year"];
            return View("StudentDisplay");

        }
    }
}
