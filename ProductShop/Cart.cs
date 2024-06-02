using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ProductShop
{
    internal class Cart
    {
       public List<Product> cartItems= new List<Product>();
        public void AddToCart(Product product) 
        {
            cartItems.Add(product);
        }
        public void RemoveFromCart(int productId) 
        {
            cartItems.RemoveAll(p=>p.Id==productId);
        }
        public decimal GetTotalPrice() 
        {
            return cartItems.Sum(p => p.Price);
        }
        public List<Product> GetCartItems()
        {
            return new List<Product>(cartItems);
        }
    }
}
