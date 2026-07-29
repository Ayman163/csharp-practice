using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Man";
            human1.age = 20;

            human2.name = "Weman";
            human2.age = 18;

            human1.Sleep();
            human1.Eat();

            human2.Sleep();
            human2.Eat();
            

            Console.ReadKey();
        }
    class Human
        {
            public String name;
            public int age;
            public void Eat()
            {
                Console.WriteLine(name + " is eating");
            }
            public void Sleep()
            {
                Console.WriteLine(name + " is sleeping");
            }
        }
    }
}
