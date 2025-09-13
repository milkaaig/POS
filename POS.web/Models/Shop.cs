using System.ComponentModel.DataAnnotations;

namespace POS.web.Models
{
    public class Shop
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Shop Name Required")]
        public string Name { get; set; }
    }
    
}
