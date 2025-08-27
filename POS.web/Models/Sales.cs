using System.ComponentModel.DataAnnotations;

namespace POS.web.Models
{
    public class Sales
    {

        public  int  SalesId { get; set; }


        [Required]
        public DateOnly SaleDate { get; set; }
        public int? TotalPrice { get; set; }

        [Required]
        public int?  EmployeeId { get; set; }
        public virtual Employees Employees { get; set; }

        public int? ShopId { get; set; }
        public virtual Shop Shop { get; set;  }

    }
}
