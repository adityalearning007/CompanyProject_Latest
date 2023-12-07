using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Int64  Contact { get; set; }
        public string? Address { get; set; }
        public string? Department { get; set; }
        public DateTime? DOJ { get; set; }
    }
}
