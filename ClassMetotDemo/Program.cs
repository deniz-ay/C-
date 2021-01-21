using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123456;
            customer1.Money = 706.45;
            customer1.Name = "Adil";
            customer1.Surname = "yıldız";
            Customer customer2 = new Customer();
            customer2.Id = 11111;
            customer2.Money = 560.45;
            customer2.Name = "Deniz";
            customer2.Surname = "Ay";
            Customer customer3 = new Customer();
            customer3.Id = 11212;
            customer3.Money = 566.45;
            customer3.Name = "Murat";
            customer3.Surname = "Işık";
            Customer[] allCustomers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(allCustomers);
            customerManager.Delete(customer1);
            customerManager.List(allCustomers);

        }
    }
}
