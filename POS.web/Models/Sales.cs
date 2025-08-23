namespace POS.web.Models
{
    public class Sales
    {
        public SalesItems SalesId { get; set; }
        public SalesItems SaleDate { get; set; }
        public SalesItems TotalPrice { get; set; }
        public SalesItems EmployeeId { get; set; }
    }
}
