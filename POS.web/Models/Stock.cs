using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.web.Models
{
    public class Stock
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Stocked In date is Required")]
        public DateOnly StockedIn { get; set; }

        [Required(ErrorMessage = "Stocked Out date is Required")]
        public DateOnly? StockedOut { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
