using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what day is it today?");  
            string day = Console.ReadLine();
            switch(day)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

        }
    }
}
