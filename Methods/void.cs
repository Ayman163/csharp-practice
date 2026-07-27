using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String name = "Ayman";
            int age = 20;

            SingHappyBirthday(name, age);

            Console.ReadKey();
        }
        static void SingHappyBirthday(String b, int years)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + b);
            Console.WriteLine("You are " + years + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}
