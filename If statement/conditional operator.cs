using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            string message;

            Console.Write("Enter the Temperature: ");
            temperature = Convert.ToDouble(Console.ReadLine());

            //if(temperature >= 15)
            //{
                //message = "Is's warm outside! ";
            //}
            //else
            //{
                //message = "Is's cold outside! ";
            //}

            //Console.WriteLine(message);

            //message = (temperature >=15) ? "Is's warm outside! " : "Is's cold outside! ";

            //Console.WriteLine(message);
            
            Console.WriteLine((temperature >=15) ? "Is's warm outside! " : "Is's cold outside! ");

            Console.ReadKey();
        }
    }
}
