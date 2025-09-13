using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace POS.web.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Role Name Required")]
        public string Name { get; set; }

        // Navigation property for related employees
        public virtual ICollection<Employees> Employees { get; set; } 
    }
}
