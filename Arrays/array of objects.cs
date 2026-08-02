using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Car objects
            Car[] garage = new Car[3];

            Car car1 = new Car("BMW");
            Car car2 = new Car("Audi");
            Car car3 = new Car("Mercedes");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            // Accessing the elements of the array
            Console.WriteLine("Garage contains:");
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            // Using a foreach loop to iterate through the array
            Console.WriteLine("Garage contains in foreach:");
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            // You can also initialize the array directly like this:
            Car[] Garage = { new Car("BMW"),new Car("Audi"),new Car("Mercedes")};
        }   
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
