using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Gözde";
            customer1.Surname = "Toz";
            Customer customer2 = new Customer();
            customer2.Name = "Tuncay";
            customer2.Surname = "Can";
            Customer customer3 = new Customer();
            customer3.Name = "Burak";
            customer3.Surname = "Toz";

            CustomerManeger customerManager = new CustomerManeger();

            customerManager.Add(customer1);
            customerManager.Get(customer1,customer2, customer3);
            customerManager.Delete(customer3);
            
        }
    }
}
