using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = new string[3];
            //cars[0] = "BMW";
            //cars[1] = "Mustang";
            //cars[2] ="Corvtte";
            String[] cars = { "BMW", "Mustang","Corvtte"};

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine("Chnage first one to: ");
            cars[0] = Console.ReadLine();
            Console.WriteLine("in for loop");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
