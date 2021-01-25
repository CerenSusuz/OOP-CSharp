using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer instance created
            Customer customer = new Customer();
            customer.Name = "Ceren";
            customer.Surname = "Susuz";
            customer.Phone = "0555 555 55 55";
            customer.Address = "İzmir";
            customer.Birthday = "20/03/1997";

            //methods test

            //create methods
            CustomerManager cmanager = new CustomerManager();
            cmanager.Create(customer);
            Console.WriteLine("create method checked\n");
            cmanager.ReadInfo(customer);
            Console.WriteLine("read method checked\n");
            //customer instance changed
            customer.Name = "Asya";
            customer.Surname = "Susuz";
            customer.Phone = "0555 555 55 55";
            customer.Address = "İzmir";
            customer.Birthday = "26/06/2009";
            cmanager.Update(customer);
            Console.WriteLine("update method checked\n");
            cmanager.Delete(customer);
            Console.WriteLine("delete method checked\n");
        }
    }
}

