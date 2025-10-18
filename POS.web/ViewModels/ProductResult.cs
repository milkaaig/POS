
namespace POS.web.ViewModels
{

public class ProductResult
{
    public int ProductId { get; set; }
    public String ProductName { get; set; }
    public String Category { get; set;  }
    public int Quantity { get; set;  }
    public decimal Price { get; set; }
    public decimal Total => Price * Quantity;
}



}