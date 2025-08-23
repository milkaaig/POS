namespace POS.web.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public Roles Role { get; set; }

    }
}
