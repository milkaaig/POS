using System.ComponentModel.DataAnnotations;

namespace POS.web.Models
{
    public class Shop


    {
        [Required]
        public int? Id { get; set; }
        public string Name { get; set; }

    }
}
