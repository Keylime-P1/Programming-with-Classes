using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("2087 Berggren Ln", "Idaho Falls", "Idaho", "United States");
        Customer customer1 = new Customer("Greg", myAddress);
        // myAddress.DisplayAddress();
        customer1.GetAddress().DisplayAddress();
        Product milk = new Product("milk", 0001, 2.13, 2);
        Product bread = new Product("Bread", 0002, 1.99, 3);
        // Console.WriteLine("$" + milk.GetPriceTotal());
        Order myOrder = new Order();
        myOrder.SetCustomer(customer1);
        myOrder.AddProduct(milk);
        myOrder.AddProduct(bread);
        myOrder.GetOrderTotal();
        myOrder.DisplayOrderTotal();
        myOrder.DisplayOrder();

        // Console.WriteLine(myOrder.GetCustomer().GetAddress().GetCountry());
        myOrder.CheckCountry();
        myOrder.DisplayOrderTotal();
        Console.WriteLine();

        Address addy2 = new Address("1234 Gregory St", "Pripyet", "Ukraine", "Russia");
        Customer customer2 = new Customer("Vlad", addy2);
        customer2.GetAddress().DisplayAddress();
        Product vodka = new Product("vodka", 0003, 4.38, 10);
        Product cheese = new Product("cheese", 0004, 3.38, 4);
        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProduct(vodka);
        order2.AddProduct(cheese);
        order2.GetOrderTotal();
        order2.DisplayOrder();
        order2.DisplayOrderTotal();
        order2.CheckCountry();
        order2.DisplayOrderTotal();
    }
}