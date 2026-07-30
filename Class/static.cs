using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine("without static: ");

            Console.WriteLine(car1.numberOfCars1);// = 1
            Console.WriteLine(car2.numberOfCars1);// = 1
            Console.WriteLine(car3.numberOfCars1);// = 1

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("with static: ");


            Console.WriteLine(Car.numberOfCars);// = 3
            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;
        public  int numberOfCars1;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
            numberOfCars1++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
