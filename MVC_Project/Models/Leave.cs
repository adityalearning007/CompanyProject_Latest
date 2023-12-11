namespace MVC_Project.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public string? Leave_Status { get; set; }
        public string? Reason { get; set; }
    }
}
