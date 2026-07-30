using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of products: ");
            int count = Convert.ToInt32(Console.ReadLine());

            decimal total = CalculateTotal(count);
            decimal final = CalculateDiscount(total, 0.10m);
            decimal discountValue = total - final;

            PrintReceipt(total, discountValue, final);
         
        }
        static decimal CalculateTotal(int productCount)
        {
            decimal totalPrice = 0m;
             for (int i = 0;i < productCount;i++)
            {
                Console.WriteLine($"Enter the price of product number {i+1}: ");
                totalPrice += Convert.ToDecimal(Console.ReadLine());
            } 
            return totalPrice;
        }
        static decimal CalculateDiscount(decimal totalPrice, decimal discountRate)
        {
            decimal final;
            if (totalPrice >=100)
            {
                final = totalPrice - (totalPrice * discountRate);
            }
            else
            {
                final = totalPrice;
            }
            return final;
        }
        static void PrintReceipt(decimal totalPrice, decimal discountAmount, decimal finalPrice)
        {
            Console.WriteLine("\n--- RECEIPT SUMMARY ---");
            Console.WriteLine($"Total price before discount : ${totalPrice:F2}");
            Console.WriteLine($"Value of discount           : ${discountAmount:F2}");
            Console.WriteLine($"The final price             : ${finalPrice:F2}");
        }
    }
}
