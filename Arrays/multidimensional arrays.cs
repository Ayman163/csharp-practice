using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                    { "Corvette", "Camaro", "Silverado" }, 
                                    { "Corolla", "Camry", "Rav4" }};

            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("-------------------------------");

            parkingLot[0,2] = "Fusion";

            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("-------------------------------");

            parkingLot[2, 0] = "Tacoma";
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("-------------------------------");

            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for(int j = 0; j < parkingLot.GetLength(0); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
