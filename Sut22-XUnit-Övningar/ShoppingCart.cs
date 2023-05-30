using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut22_XUnit_Övningar
{
    public class ShoppingCart
    {
        private List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach(var item in products)
            {
                totalPrice+=item.Price;
            }
            return totalPrice;
        }
    }
}
