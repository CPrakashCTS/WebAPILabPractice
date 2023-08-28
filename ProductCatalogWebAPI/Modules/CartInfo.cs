namespace ProductCatalogWebAPI.Modules
{
    public class CartInfo
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public int ProductId { get; set; }
        public int BuyQuantity {  get; set; }
        public int TotalAmount { get; set; }
    }
}
