using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace POS.web.Models


{

    // This is used for Receipt printing
    public class SalesItems
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Sales Date is Required")]
        public DateTime SaleDate { get; set; }  



        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }


        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "Unit Price is Required")]
        public int UnitPrice { get; set; }

        [Required(ErrorMessage = "Total Price is Required")]
        public int TotalPrice { get; set; }


        [Required]
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }

        public virtual Employees Employee { get; set; }
    }
}
