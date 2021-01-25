using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Create(Customer customer)
        {
            Console.WriteLine($"{customer.Name} created...");
        }
        public void ReadInfo(Customer customer)
        {
            Console.WriteLine($"In here -> \n{customer.Name}\n{customer.Surname}\n{customer.Phone}\n{customer.Birthday}\n{customer.Address}\nchecked...");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine($"In here -> \n{customer.Name}\n{customer.Surname}\n{customer.Phone}\n{customer.Birthday}\n{customer.Address}\nupdated...");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} deleted...");
        }
    }
}