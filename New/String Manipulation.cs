using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawin = "            Ayman Developer   ";

            Console.WriteLine("raw: " + rawin);

            string cleanInput = rawin.Trim();
            
            Console.WriteLine("Clean:" + cleanInput);

            string upperInput = cleanInput.ToUpper();
            
            Console.WriteLine("All Upper: " + upperInput);

            bool hasDev = cleanInput.Contains("Developer");
         
        }
        
    }
}
