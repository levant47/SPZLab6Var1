using System;
using System.Collections.Generic;
using System.Linq;

namespace SPZLab6Var1
{
    public static class Shop
    {
        public static List<ProductType> ProductTypes = new List<ProductType>
        {
            new ProductType { Id = 1, Name = "Butter", Quantity = 100, BuyingPrice = 10, SellingPrice = 12 },
            new ProductType { Id = 2, Name = "Bread", Quantity = 100, BuyingPrice = 15, SellingPrice = 17 },
            new ProductType { Id = 3, Name = "Milk", Quantity = 100, BuyingPrice = 20, SellingPrice = 22 },
            new ProductType { Id = 4, Name = "Sugar", Quantity = 100, BuyingPrice = 25, SellingPrice = 27 },
        };

        public static float Cash = 10000;
        public static int PurchaseCount = 0;

        public static void Purchase(int productTypeId, int quantity)
        {
            var targetProduct = ProductTypes.First(productType => productType.Id == productTypeId);
            var boughtQuantity = Math.Clamp(quantity, 0, targetProduct.Quantity);
            targetProduct.Quantity -= boughtQuantity;
            Cash += boughtQuantity * targetProduct.SellingPrice;
            PurchaseCount += 1;
        }
    }
}

