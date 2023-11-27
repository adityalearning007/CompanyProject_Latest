using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class ValueController : Controller
    {
        private readonly CompanydbContext _context;
        public ValueController(CompanydbContext context)
        {
            _context = context;
        }
        public IActionResult Display()
        {
            return View();
        }
        public void CallMe()
        {
            var item = _context.tblEmployee.ToList();

            Console.WriteLine("Test");
        }
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Employee Obj)
        {
            return View();
        }

    }
}
