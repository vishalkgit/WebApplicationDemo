using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>() { "Pune","Mumbai","Nashik","Chh.Sambhajinagar"};
            ViewData["cities"]=new SelectList(cities);
            return View();
        }


        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.Name = form["personname"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            return View("Display");
        }
    }
}
