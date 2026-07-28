using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Ayman";
            int age = 21;

            Console.WriteLine($"Hello {firstName}.");
            Console.WriteLine($"You are {age,-10} old.");

            Console.ReadKey();
        }
    }
}
