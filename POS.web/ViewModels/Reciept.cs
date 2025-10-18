namespace POS.web.ViewModels
{
    public class Reciept
    {

        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;
        public List<ProductResult> ProductResult { get; set; }
        public decimal Total => ProductResult?.Sum(p => p.Total) ?? 0;
    }
}
