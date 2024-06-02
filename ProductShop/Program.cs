
namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AddProduct(new Product(1, "Apple", 3));
            shop.AddProduct(new Product(2, "Orange", 2));
            shop.AddProduct(new Product(3, "Banana", 2));
            shop.AddProduct(new Product(4, "Mango", 5));
            shop.AddProduct(new Product(5, "CocaCola", 4));
            shop.AddProduct(new Product(6, "Fanta", 4));
            shop.AddProduct(new Product(7, "Sprite", 4));
            shop.AddProduct(new Product(8, "Pepsi", 4));
            shop.AddProduct(new Product(9, "Bread", 7));
            shop.AddProduct(new Product(10, "Milk", 6));
            shop.AddProduct(new Product(11, "Fish", 15));

            Cart cart = new Cart();

            Console.WriteLine("Availible products in market:");
            foreach (var product in shop.GetAllProducts())
            {
                Console.WriteLine(product);
            }
            cart.AddToCart(shop.GetProductById(2));
            cart.AddToCart(shop.GetProductById(11));
            cart.AddToCart(shop.GetProductById(7));
            cart.AddToCart(shop.GetProductById(4));
            cart.AddToCart(shop.GetProductById(6));
            cart.AddToCart(shop.GetProductById(1));
            cart.AddToCart(shop.GetProductById(9));

            Console.WriteLine("\nProducts in cart");
            foreach (var product in cart.GetCartItems())
            {
                Console.WriteLine(product);
            }
            cart.RemoveFromCart(9);//remove item from cart
            Console.WriteLine("\nItems in cart after removing");
            foreach (var item in cart.GetCartItems())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nTotal price: {cart.GetTotalPrice()}$");
        }   
    }
}