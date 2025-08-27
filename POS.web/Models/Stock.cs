namespace POS.web.Models
{
    public class Stock
    {
        public Product ProductId { get; set; }
        public int Quantity { get; set; }
<<<<<<< Updated upstream
        public DateTime StockedIn { get; set; }
        public DateTime? StockedOut { get; set; }
        public Product ExpiryDate { get; set; }
=======

        [Required]
        public DateOnly StockedIn { get; set; }
        [Required]
        public DateOnly StockedOut { get; set; }

        [Required]
        public Product ExpiryDate { get; set; }


        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
>>>>>>> Stashed changes
    }
}
