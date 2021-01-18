using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManeger
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added " + customer.Name+" " +customer.Surname );
        }

        public void Get(params Customer[] customer)
        {
            foreach (var item in customer)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            
        }

        public void Delete(Customer customer)
        {
             Console.WriteLine("Customer is deleted "  + customer.Name + " " + customer.Surname);
        }
    }
}
