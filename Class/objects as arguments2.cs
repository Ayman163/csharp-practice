using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car car1 = new Car("BMW", "Red");

            Car car2 = Copy(car1);

            Console.WriteLine("Car model: " + car2.model + "Car color: " + car2.color);
        }   

        public static Car  Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
