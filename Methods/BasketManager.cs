using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"{product.Name}  Adding...");
        }
        public void Add2(string name, string desc, double price, int piece)
        {
            Console.WriteLine($"{name}");
        }
    }
}
