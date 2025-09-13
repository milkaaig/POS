using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace POS.web.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is Required")]
        public string Name { get; set; }

        // Navigation property for related products
        public virtual ICollection<Product> Products { get; set; }
    }
}
