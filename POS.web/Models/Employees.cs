using System.ComponentModel.DataAnnotations;
namespace POS.web.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
<<<<<<< Updated upstream
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public Roles Role { get; set; }
=======

        [Required(ErrorMessage="First Name Required")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public String LastName { get; set; }


        //foreign key for Role Table
        public  int RoleId { get; set; }
        public virtual Role Role { get; set; }
>>>>>>> Stashed changes

    }
}
