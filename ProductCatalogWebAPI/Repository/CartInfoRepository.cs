using ProductCatalogWebAPI.Modules;

namespace ProductCatalogWebAPI.Repository
{
    public class CartInfoRepository
    {
        public CartInfoRepository() { }

        List<CartInfo> cartInfos= new List<CartInfo>() { 
            new CartInfo() { CustomerId = 412, CustomerName = "Prakash1", BuyQuantity = 2, ProductId = 1234, TotalAmount = 34500 }
            , new CartInfo() { CustomerId = 413, CustomerName = "Prakash2", BuyQuantity = 3, ProductId = 1235, TotalAmount = 24500 }
            , new CartInfo() { CustomerId = 414, CustomerName = "Prakash3", BuyQuantity = 4, ProductId = 1236, TotalAmount = 54500 }
            , new CartInfo() { CustomerId = 415, CustomerName = "Prakash4", BuyQuantity = 5, ProductId = 1234, TotalAmount = 44500 }
            , new CartInfo() { CustomerId = 416, CustomerName = "Prakash5", BuyQuantity = 6, ProductId = 1237, TotalAmount = 64500 }
        };

        public List<CartInfo> GetCartInfo() { return cartInfos; }

    }
}
