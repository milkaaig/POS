namespace POS.web.Models
{
    public class Stock
    {
        public Product ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime StockedIn { get; set; }
        public DateTime? StockedOut { get; set; }
        public Product ExpiryDate { get; set; }
    }
}
