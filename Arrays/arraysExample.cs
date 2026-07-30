using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] devices = new string[3] { "Laptop", "Desktop", "Monitor"};

            Console.WriteLine($"FIrst Device : {devices[0]}");

            devices[1] = " Gaming pc";

            foreach (string device in devices)
            {
                Console.WriteLine($"Device: {device}");
            }
         
        }
        
    }
}
