namespace POS.web.Models
{
    public class Sales
    {
<<<<<<< Updated upstream
        public SalesItems SalesId { get; set; }
        public SalesItems SaleDate { get; set; }
        public SalesItems TotalPrice { get; set; }
        public SalesItems EmployeeId { get; set; }
=======

        public  int  SalesId { get; set; }


        [Required(ErrorMessage ="Sales Date Required")]
        public DateOnly SaleDate { get; set; }

        [Required(ErrorMessage = "Total Price Required")]
        public int TotalPrice { get; set; }

        public int  EmployeeId { get; set; }
        public virtual Employees Employees { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set;  }

>>>>>>> Stashed changes
    }
}
