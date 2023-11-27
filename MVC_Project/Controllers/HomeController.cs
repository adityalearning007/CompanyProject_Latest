using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanydbContext _context;


        public HomeController(CompanydbContext context)
        {   
            _context = context;
        }
        public IActionResult Index()
        {
            var item=_context.tblEmployee.ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}