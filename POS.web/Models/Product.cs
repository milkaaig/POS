using Microsoft.Identity.Client;

namespace POS.web.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public Categories Category { get; set; }
        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }



    }
}
