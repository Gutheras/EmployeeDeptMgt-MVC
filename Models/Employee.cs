namespace MVC_Practice.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Position { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
