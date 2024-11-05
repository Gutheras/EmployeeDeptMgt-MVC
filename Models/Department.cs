namespace MVC_Practice.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string Name { get; set; }
        public required List<Employee> Employees { get; set; }
    }
}
