using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //enums = special "class" that contains a set of named integers called elements or members
            //use enums when you have a set of values that you know aren't going to change, like days, months, colors, deck of cards, etc.
            //to get the integer value of an enum, you can cast it to an int
            //name = integer

            Console.WriteLine(Planets.Mercury + " is a planet");
            Console.WriteLine((int)Planets.Mercury + " is the integer value of Mercury in the Planets enum");

            Console.WriteLine(Planets1.Mercury + " is a planet");
            Console.WriteLine((int)Planets1.Mercury + " is the integer value of Mercury in the Planets1 enum we assigned values to");

            String name = PlanetsRadius.Earth.ToString();
            int radius = (int)PlanetsRadius.Earth;

            Console.WriteLine("planet name is : " + name);
            Console.WriteLine("radius of planet is : " + radius + " km");

            double volume = Volume(PlanetsRadius.Earth);
            Console.WriteLine("volume of planet is : " + volume + " km^3");


        }   
        public static double Volume(PlanetsRadius radius)
        {
            //volume of a sphere = 4/3 * pi * r^3
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }
    enum Planets1
    {
        Mercury= 1,
        Venus= 2,
        Earth= 3,
        Mars= 4,
        Jupiter= 5,
        Saturn= 6,
        Uranus= 7,
        Neptune= 8
    }
    enum PlanetsRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622
    }
    
}
