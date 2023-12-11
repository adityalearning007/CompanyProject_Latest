using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Models
{
    public class CompanydbContext:DbContext
    {
        public CompanydbContext(DbContextOptions<CompanydbContext> options) : base(options) { 
        }
        //Tables        
       public DbSet<Employee> tblEmployee { get; set; }
        public DbSet<Leave> tblLeave { get; set; }

    }
}
