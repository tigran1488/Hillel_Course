using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Product_Shop
{
    internal class Shop
    {
        public List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            products.RemoveAll(p => p.Id == productId);
        }
        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }
        public List<Product> GetAllProducts()
        {
            return new List<Product>(products);
        }
    }
}
