

namespace POS.web.Models


{

    //this is used for Receipt printing
    public class SalesItems
    {
        public DateTime SaleDate { get; set; }  
        public  int SalesId { get; set; }
        public Product ProductName { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public Employees EmployeeId { get; set; }

    }
}
