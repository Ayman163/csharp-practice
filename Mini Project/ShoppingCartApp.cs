using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
         int products;
         decimal discount = 0.1m;
         decimal totalPrice = 0m;
         decimal finalPrice = 0m;
         decimal valuediscount = 0m;

         Console.WriteLine("Enter the number of products you want to buy it: ");
         products = Convert.ToInt32(Console.ReadLine());
         
         for (int i = 0;i < products;i++)
            {
                Console.WriteLine($"Enter the price of product number {i+1}: ");
                totalPrice += Convert.ToDecimal(Console.ReadLine());
            }
            if (totalPrice >=100)
            {
                finalPrice = totalPrice - (totalPrice * discount);
            }
            else
            {
                finalPrice = totalPrice;
            }

            valuediscount = totalPrice-finalPrice;

            Console.WriteLine($"The toatal price before discount is :{totalPrice}");
            Console.WriteLine($"Value of discount is:{valuediscount}");
            Console.WriteLine($"The final price is :{finalPrice}");

        }
    }
}
