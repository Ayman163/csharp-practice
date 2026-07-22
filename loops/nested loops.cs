using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
         int r;
         int c;
         char ch;
         Console.WriteLine("Enter numbers of Rwos: ");
         r = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the numbers of coulms: ");
         c = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the symbol of coulms: ");
        ch = Convert.ToChar(Console.Read());
        for (int i = 0;i < r;i++)
            {
                for (int j = 0;j < c;j++)
                {
                Console.Write(ch);
                }
            Console.WriteLine();
            }

        }
    }
}
