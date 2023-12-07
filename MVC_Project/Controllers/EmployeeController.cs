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
            if (Obj.Emp_Id == 0)
            {
                _context.tblEmployee.Add(Obj);
                _context.SaveChanges();
            }
            else
            {
                var result = _context.tblEmployee.FirstOrDefault(e => e.Emp_Id == Obj.Emp_Id);
                if (result != null)
                {
                    //Employee obj = new Employee();
                    result.FirstName= Obj.FirstName;
                    result.LastName= Obj.LastName;   
                    result.DOJ= Obj.DOJ;
                    result.Address= Obj.Address;
                    result.Department = Obj.Department;
                    result.Contact= Obj.Contact;
                    _context.SaveChanges();
                }
            }
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
        public IActionResult EditEmployee()
        {
            Employee obj = new Employee();
            obj.Address = "Mumbai";

            return View(obj);
        }
        [HttpPost]
        public IActionResult EditEmployee(Employee Obj)
        {
            Employee obj = new Employee();
            obj.Address = "Mumbai";

            return View(obj);
        }

        //public void UpdateEmployee()
        //{
       
        //}
        [HttpGet]
        public IActionResult GetEmployee()
        {
            List<Employee> lstEmp = _context.tblEmployee.ToList();
            List<Employee> LstNew = new List<Employee>();
            //foreach (Employee obj in lstEmp)
            //{
            //    LstNew.Add(new Employee { Address = obj.Address, DOJ = Convert.ToDateTime(obj.DOJ.ToString("MM/dd/yyyy")) });
            //}
            return View(lstEmp);
        }
        
        public void deleteEmployee(int EmpId)
        {
            var result = _context.tblEmployee.FirstOrDefault(e => e.Emp_Id == EmpId);
            if(result != null)
            {
                _context.tblEmployee.Remove(result);
                _context.SaveChanges();
            }
        }
        //[HttpGet]
        public IActionResult UpdateEmployee(int EmpId)
        {
            List<Employee> lst = _context.tblEmployee.Where(e => e.Emp_Id == EmpId).ToList();
            Employee Obj = new Employee();
            foreach (var item in lst)
            {
                Obj.FirstName = item.FirstName;
                Obj.LastName= item.LastName;
                Obj.Address = item.Address;
                Obj.Department = item.Department;
                Obj.DOJ = item.DOJ;
                Obj.Contact= item.Contact;
                Obj.Emp_Id= item.Emp_Id;
            }
            return View(Obj);
            
        }

    }
}
