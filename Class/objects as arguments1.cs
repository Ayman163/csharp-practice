using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car car1 = new Car("BMW", "Red");

            ChangeColor(car1, "Blue");

            Console.WriteLine("Car model: " + car1.model + "Car color: " + car1.color);
        }   

        public static void ChangeColor(Car car, String Color)
        {
            car.color = Color;
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
