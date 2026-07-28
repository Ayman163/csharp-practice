using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
         do
            {
                Console.Write("Enter your name:");
                name = Console.ReadLine();
            }while (name == "");
            Console.WriteLine("Hello " + name);
        }
    }
}
