using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Messagess msg = new Messagess();
            
            msg.Helloo();
            msg.Waitingo();
            msg.Byeo();

            Console.ReadKey();
        }
    }
    class Messagess
    {
        public void Helloo()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public void Waitingo()
        {
            Console.WriteLine("I am waiting for something");
        }
        public void Byeo()
        {
            Console.WriteLine("Bye! Thanks for visiting");
        }
    }
}
