using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter number one to add:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Beep(80, 200);
            Console.WriteLine("Enter number two to add:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Beep(80, 200);
            c = a + b;
            Console.WriteLine("The sum is: " + c);
        }
    }
}
