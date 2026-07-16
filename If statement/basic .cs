using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");  
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18 && age <= 120)
            {
                Console.WriteLine("You are now signed up for the service.");
            }
            else if (age < 0 || age > 120)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            else
            {
                Console.WriteLine("You must be at least 18 years old to sign up.");
            }
        }
    }
}
