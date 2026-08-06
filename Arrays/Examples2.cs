using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> hardwarePrices = new Dictionary<string, decimal>();

            hardwarePrices.Add("RTX 4080", 1199.99m);

            hardwarePrices["i9-14900K"] = 589.00m;//anthor way to add
            
            if (hardwarePrices.TryGetValue("RTX 4080", out decimal price))
            {
                Console.WriteLine($"Price of RTX 4080 is ${price:F2}");
            }
        }
    }
}
