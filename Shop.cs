using System;
using System.Collections.Generic;
using System.Linq;

namespace SPZLab6Var1
{
    public static class Shop
    {
        private static object _mutex = new object();
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
            lock (_mutex)
            {
                targetProduct.Quantity -= boughtQuantity;
                Cash += boughtQuantity * targetProduct.SellingPrice;
                PurchaseCount += 1;
            }
        }

        public static void Restock(int id, int quantity)
        {
            var targetProductType = ProductTypes.First(productType => productType.Id == id);
            lock (_mutex)
            {
                targetProductType.Quantity += quantity;
                Cash = Math.Max(0, Cash - quantity * targetProductType.BuyingPrice);
            }
        }
    }
}

