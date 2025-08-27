using System.ComponentModel.DataAnnotations;

namespace POS.web.Models
{
    public class Stock
    {
        [Required]
        public Product ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateOnly? StockedIn { get; set; }
        [Required]
        public DateOnly? StockedOut { get; set; }

        [Required]
        public Product? ExpiryDate { get; set; }


        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
