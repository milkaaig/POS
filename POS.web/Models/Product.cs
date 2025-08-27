using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
namespace POS.web.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }
<<<<<<< Updated upstream
        public Categories Category { get; set; }
        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }
=======
       
        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Expiry Date is Required")]
        public DateOnly ExpiryDate { get; set; }


        // foreign key from Category table
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
>>>>>>> Stashed changes



    }
}
