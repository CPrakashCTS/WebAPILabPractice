namespace ProductCatalogWebAPI.Modules
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryDescription { get; set;}
        public int ProductPrice { get; set; }
        public int ProductDiscountRate { get; set; }
        public bool ProductInStock {  get; set; }

    }
}
