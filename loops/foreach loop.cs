using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "BMW", "Mustang","Corvtte"};
            
            //for (int i = 0; i < cars.Length; i++)
            //{
                //Console.WriteLine(cars[i]);
           // }
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
