using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer = new Individual();
            customer.Id = 1;
            customer.Name = "Ceren";
            customer.Surname = "Susuz";
            customer.IdentificationNumber = "123";
            customer.CustomerNumber = "123";


            Coorporate company = new Coorporate();
            company.Id = 2;
            company.CustomerNumber = "123";
            company.CompanyName = "CS";
            company.TaxNumber = "123";

            Customer customer1 = new Individual();
            Customer customer2 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Create(customer);
            customerManager.Create(customer1);
            customerManager.Create(customer2);





        }
    }
}
