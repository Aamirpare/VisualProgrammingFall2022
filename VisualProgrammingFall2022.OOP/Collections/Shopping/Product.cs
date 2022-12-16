using System;
using System.Collections.Generic;

namespace VisualProgrammingFall2022.OOP.Collections.Shopping
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    class ShoppingCart
    {
        List<Product> Products { set; get; } = new List<Product>();
        public int Count { get; set; }

        /// <summary>
        /// This method adds an item to the Shopping cart
        /// </summary>
        /// <param name="product">item to be added into the cart</param>
        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Method(Product product)
        {
            Products.Remove(product);
        }

        public void Clear()
        {
            Products.Clear();
        }


        public decimal CalculatePrice()
        {
            decimal totalPrice = 0;
            foreach (var product in Products)
            {
                totalPrice += product.Price; 
            }
            return totalPrice;
        }


        public void Display()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Quanity: {product.Quantity}");
                Console.WriteLine($"Price: {product.Price}");
            }
        }
    }
    public static class ShoppingCartDemo
    {
        public static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            Product tea = new Product()
            {
                Name = "Pink Tea",
                Price = 56.99m
            };

            cart.Add(tea);

            Product tobacco = new Product();
            tobacco.Name = "Gold Leaf";
            cart.Add(tobacco);

            cart.Display();

            Console.WriteLine("========");

            cart.Add(new Product { Name ="Mango", Price=899.99m, Quantity=5 });

            //cart.Products.Add(new Product { Name = "Peach", Price = 456.0m, Quantity = 4 });

            cart.Display();

            Console.ReadKey();
        }
    }
}
