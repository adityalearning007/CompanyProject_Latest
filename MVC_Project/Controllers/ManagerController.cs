using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class ManagerController : Controller
    {
        private readonly CompanydbContext _context;
        public ManagerController(CompanydbContext context)
        {
            _context = context;
        }

        public IActionResult getLeaveApplication()
        {
            List<Leave> lstLeave = _context.tblLeave.Where(e => e.Leave_Status == "Pending").ToList();
            return View(lstLeave);
        }
        public IActionResult ApproveLeave(int Id)
        {
            var result = _context.tblLeave.FirstOrDefault(e => e.Id == Id);
            if (result != null)
            {
                result.Leave_Status = "Approve";
                _context.SaveChanges();
            }
            return View();
        }
        public IActionResult RejectLeave(int Id)
        {
            var result = _context.tblLeave.FirstOrDefault(e => e.Id == Id);
            if (result != null)
            {
                result.Leave_Status = "Reject";
                _context.SaveChanges();
            }
            return View();
        }

    }
}
