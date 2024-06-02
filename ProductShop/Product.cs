using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ProductShop
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{Id}: {Name} - {Price}";
        }
    }
}
