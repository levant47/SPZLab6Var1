using System.Collections.Generic;

namespace SPZLab6Var1
{
    public static class Shop
    {
        public static List<ProductType> ProductTypes = new List<ProductType>
        {
            new ProductType { Id = 1, Name = "Butter", Quantity = 100, BuyingPrice = 10, SellingPrice = 12 },
            new ProductType { Id = 1, Name = "Bread", Quantity = 100, BuyingPrice = 15, SellingPrice = 17 },
            new ProductType { Id = 1, Name = "Milk", Quantity = 100, BuyingPrice = 20, SellingPrice = 22 },
            new ProductType { Id = 1, Name = "Sugar", Quantity = 100, BuyingPrice = 25, SellingPrice = 27 },
        };

        public static float Cash = 10000;
    }
}

