using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namestudent = {"aymaN","AhMad","  rem ", " rana "};

            foreach (string names in namestudent)
            {
                string cleannames = names.Trim().ToUpper();
                Console.WriteLine($"Hello {cleannames}");
            }
         
        }
        
    }
}
