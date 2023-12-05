using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly CompanydbContext _context;

        public EmployeeController(CompanydbContext context)
        { 
            _context = context;
        }
        [HttpGet] //HTTP VERBS
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Save(Employee Obj)
        {
            _context.tblEmployee.Add(Obj);
            _context.SaveChanges();            
        }
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewEmployee(int id)
        {
            Employee obj=new Employee();
            obj.Address = "Mumbai";
            return View(obj);
        }
        
        public void UpdateEmployee()
        {
            var result = _context.tblEmployee.FirstOrDefault(e => e.Emp_Id == 2);
            if (result != null)
            {
                Employee obj = new Employee();
                result.Department = "ADMIN";
                result.LastName = "Pimple";
                _context.SaveChanges();
            }
        }
        public IActionResult getAllEmployee()
        {
            List<Employee> lstEmp = _context.tblEmployee.ToList();
            return View(lstEmp);
        }
        
        public void deleteEmployee(int id)
        {
            var result = _context.tblEmployee.FirstOrDefault(e => e.Emp_Id == 2);
            if(result != null)
            {
                _context.tblEmployee.Remove(result);
                _context.SaveChanges();
            }

        }

    }
}
