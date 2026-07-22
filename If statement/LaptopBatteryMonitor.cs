using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
         int batteryLevel;
         bool isPluggedIn;
         Console.WriteLine("How much is battery level:");
         batteryLevel = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("It is plugged in true or false:");
         isPluggedIn = Convert.ToBoolean(Console.ReadLine());
         if (batteryLevel <=20 && !isPluggedIn)
            {
                Console.WriteLine("please plugg in.");
            }
        else if (batteryLevel == 100 && isPluggedIn)
        {
            Console.WriteLine("the battery is full plug off.");
        }
        else 
            {
             Console.WriteLine("everything good.");
            }
        }
    }
}
