using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class LeaveController : Controller
    {
        readonly private CompanydbContext _context;
        public LeaveController(CompanydbContext context)
        {   
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LeaveApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LeaveApplication(Leave Obj)
        {
            if (Obj.Id == 0)
            {
                Leave ObjLeave  = new Leave();
                ObjLeave.PlanStartDate = Obj.PlanStartDate;
                ObjLeave.PlanEndDate= Obj.PlanEndDate;
                ObjLeave.EmpId = 3;//value come from session
                ObjLeave.Leave_Status = "Pending";
                ObjLeave.Reason = Obj.Reason;
                _context.tblLeave.Add(ObjLeave);
                _context.SaveChanges();
            }
            return View();
        }
       
    }
}
