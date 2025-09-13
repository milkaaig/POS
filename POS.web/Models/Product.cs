using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace POS.web.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Expiry Date is Required")]
        public DateOnly ExpiryDate { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        // Navigation property for related stocks
        public virtual ICollection<Stock> Stocks { get; set; } 
    }
}
