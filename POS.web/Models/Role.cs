using System.ComponentModel.DataAnnotations;
namespace POS.web.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Role Name Required")]
        public string Name { get; set; }
    }
}
