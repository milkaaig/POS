namespace POS.web.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }


        //foreign key for Role Table
        public  int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
