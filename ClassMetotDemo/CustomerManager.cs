using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer[] customer)
        {
            foreach (Customer item in customer)
            {
                Console.WriteLine(item.Name+ " "+item.Surname+" Added");
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Deleted");
        }
        public void List(Customer[] customer)
        {
            foreach (Customer item in customer)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " is your customer");
            }
        }
    }
}
