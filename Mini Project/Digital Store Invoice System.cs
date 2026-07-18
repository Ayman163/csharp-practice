using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = "Mouse";
           double price = 36.99;
           double tax = 0.15;
           double discount = 5.23;
           double taxAmount = price * tax;
           double finalPrice = price + taxAmount - discount;
           Console.WriteLine($"name of Product is :{name}");
           Console.WriteLine($"Price of {name} is :{price}");
           Console.WriteLine($"Value of tax is :{taxAmount}");
           Console.WriteLine($"discout is :{discount}");
           Console.WriteLine($"final price of {name} is :{finalPrice}");
        }
    }
}
