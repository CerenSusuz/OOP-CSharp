using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product();
            productOne.Name = "Asus Computer";
            productOne.Price = 5000;
            productOne.Description = "Nice";
            productOne.Piece = 3;

            Product productTwo = new Product();
            productTwo.Name = "Iphone";
            productTwo.Price = 12000;
            productTwo.Description = "Expensive";
            productTwo.Piece = 3;

            Product[] products = new Product[] {productOne, productTwo };

            foreach (Product product in products)
            {
                Console.WriteLine($"Name = {product.Name} \n Price= {product.Price}");
            }

            Console.WriteLine("------------Methods-------------");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(productOne);
            basketManager.Add2("iphone", "good", 12000, 5);



        }
    }
}
